using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    /// <summary>
    /// Размер уменьшенных копий изображений
    /// </summary>
    [Flags]
    public enum ThumbnailSize
    {
        W100XH100 = 0x2,
        W150XH150 = 0x4,
        W200XH200 = 0x8,
        W300XH300 = 0x10,
        W50XH50 = 0x20,
        ALL = int.MaxValue,
    }
}
