# Yandex.Market Content API Client
 
An unofficial client library for accessing the Yandex.Market Content API via ApiSystem.

The service allows you to get lists of product categories, product features and their images and reviews.

The class structure is based on the official Yandex documentation and was created in 2020.

## Yandex.Market

Yandex Market (Russian: Яндекс Маркет, tr. Yandeks Market; stylised as Yandex.Market) is a Russian online service for the selection of goods and shopping. The service was launched on November 30, 2000 by Yandex. Since 2016, it is a separate company.

The service has a daily audience of over 4 million users and monthly audience of 20 million.

Official website:

- [https://market.yandex.ru/](https://market.yandex.ru/)
- [For partners](https://partner.market.yandex.ru/)

## ApiSystem

After Sberbank bought Yandex.Market in 2020 and launched the Beru marketplace, the official content API was closed.

At the moment, access is possible through the ApiSystem proxy service.

Official website:

- [https://www.apisystem.name/](https://www.apisystem.name/)

## How to use

```cs
using System.Text;
using XyloCode.ThirdPartyServices.YandexMarket;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;
using XyloCode.ThirdPartyServices.YandexMarket.QueryModels;
using XyloCode.ThirdPartyServices.YandexMarket.ResponseModels;


namespace YandexMarketConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "http://market.apisystem.name/";
            string apiKey = "Get a token on the site https://www.apisystem.name/";
            var market = new YandexMarketConnection(server, apiKey);

            string jsonContent;

            #region Regions
            var childRegionQueue = new Queue<int>();
            var parentRegionQueue = new Queue<int>();

            RegionListResponseModel regionListResponse;
            RegionChildrenListResponseModel regionChildrenListResponse;


            var regionsRootRequest = new RegionListQueryModel()
            {
                count = 30,
                page = 0,
                fields = RegionFields.ALL,
            };

            do
            {
                regionsRootRequest.page++;
                regionListResponse = market.Request<RegionListQueryModel, RegionListResponseModel>(regionsRootRequest, out jsonContent);
                SaveToFile(jsonContent, $"RegionList_root_{regionsRootRequest.page}.json");

                foreach (var region in regionListResponse.Regions)
                {
                    if (region.ChildCount > 0)
                    {
                        childRegionQueue.Enqueue(region.Id);
                    }

                    if (region.ParentId > 0)
                    {
                        parentRegionQueue.Enqueue(region.ParentId.Value);
                    }
                }

                
            } while (regionsRootRequest.page < regionListResponse.Context.Page.Total);


            while (childRegionQueue.Count > 0)
            {
                var parent = childRegionQueue.Dequeue();
                var childRegionRequest = new RegionChildrenListQueryModel(parent)
                {
                    count = 30,
                    page = 0,
                    fields = RegionFields.ALL,
                };

                do
                {
                    childRegionRequest.page++;
                    regionChildrenListResponse = market.Request<RegionChildrenListQueryModel, RegionChildrenListResponseModel>(childRegionRequest, out jsonContent);
                    SaveToFile(jsonContent, $"RegionList_ChildOf_{parent}_{childRegionRequest.page}.json");

                    foreach (var region in regionListResponse.Regions)
                    {
                        if (region.ChildCount > 0)
                        {
                            childRegionQueue.Enqueue(region.Id);
                        }
                    }
                } while (childRegionRequest.page < regionChildrenListResponse.Context.Page.Total);
            }

            while (parentRegionQueue.Count > 0)
            {
                // like childRegionQueue
                break;
            }
            #endregion Regions


            #region Categories
            CategoryListResponseModel categoryListResponse;
            CategoryChildrenListResponseModel categoryChildrenListResponse;

            int example_region_id = 2;
            var categoryListRequest = new CategoryListQueryModel(example_region_id)
            {
                count = 30,
                page = 0,
                fields = CategoryFields.ALL,
            };

            // next like Regions
            #endregion Categories


            #region Top Models
            ModelPopularListResponseModel popularListResponse;
            
            int exampleCategoryId = 123;
            var popularListRequest = new ModelPopularListQueryModel(exampleCategoryId)
            {
                count = 30,
                page = 0,
                fields = ModelFields.STANDARD,
            };

            do
            {
                popularListRequest.page++;
                popularListResponse = market.Request<ModelPopularListQueryModel, ModelPopularListResponseModel>(popularListRequest, out jsonContent);
                SaveToFile(jsonContent, $"PopModels_Category_{exampleCategoryId}_{popularListRequest.page}.json");

            } while (popularListRequest.page < popularListResponse.Context.Page.Total);
            #endregion Top Models


            Console.Beep();
            Console.WriteLine("End!");
        }


        public static void SaveToFile(string jsonContent, string fileName)
        {

            var sw = new StreamWriter($"{fileName}", false, Encoding.UTF8);
            sw.WriteLine(jsonContent);
            sw.Close();
        }
    }
}
```

