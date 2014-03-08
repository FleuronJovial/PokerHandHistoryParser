namespace HandHistories.Objects.GameDescription
{    
    /// <summary>
    /// This is used so we can convert a Limit from an object into a a few bytes (currency, limit-enum, ante information).
    /// </summary>
    public enum LimitEnum : byte
    {
        Limit_1c_2c = 0,
        Limit_3c_6c = 2,
        Limit_2c_4c = 3,
        Limit_4c_4c = 17,
        Limit_5c_5c = 19,
        Limit_10c_10c = 4,
        Limit_2c_5c = 6,        
        Limit_4c_8c = 7,
        Limit_15c_15c = 8,
        Limit_5c_10c = 9,
        Limit_6c_12c = 10,        
        Limit_8c_16c = 11,
        Limit_10c_20c = 12,
        Limit_12c_25c = 14,
        Limit_10c_25c = 15, 
        Limit_25c_25c = 16,
        Limit_15c_30c = 18,
        Limit_20c_40c = 21,
        Limit_20c_20c = 22,
        Limit_25c_50c = 24,
        Limit_50c_50c = 25,
        Limit_30c_30c = 26,
        Limit_40c_80c = 27,
        Limit_50c_100c = 30,
        Limit_100c_100c = 31,
        Limit_75c_150c = 33,
        Limit_100c_200c = 36,
        Limit_200c_200c = 37,
        Limit_100c_300c = 39,
        Limit_125c_250c = 40,
        Limit_150c_300c = 42,
        Limit_200c_400c = 45,
        Limit_400c_400c = 46,
        Limit_200c_500c = 48,
        Limit_300c_500c = 51,
        Limit_300c_300c = 52,
        Limit_250c_500c = 54,
        Limit_500c_500c = 55,
        Limit_300c_600c = 57,
        Limit_600c_600c = 58,
        Limit_600c_1200c = 59,
        Limit_400c_800c = 60,
        Limit_500c_1000c = 63,
        Limit_1000c_1000c = 64,
        Limit_750c_1500c = 66,
        Limit_800c_1600c = 69,
        Limit_1000c_2000c = 72,       
        Limit_1250c_2500c = 73,
        Limit_2000c_2000c = 74,
        Limit_1500c_3000c = 75,
        Limit_2000c_4000c = 78,
        Limit_2500c_5000c = 81,
        Limit_5000c_5000c = 82,
        Limit_3000c_6000c = 84,
        Limit_4000c_8000c = 87,
        Limit_5000c_10000c = 90,
        Limit_6000c_12000c = 91,
        Limit_7500c_15000c = 93,
        Limit_10000c_10000c = 94,
        Limit_10000c_20000c = 96,        
        Limit_12500c_25000c = 97,
        Limit_15000c_30000c = 99,
        Limit_20000c_40000c = 102,
        Limit_20000c_20000c = 103,
        Limit_25000c_50000c = 105,
        Limit_30000c_30000c = 107,
        Limit_30000c_60000c = 108,
        Limit_40000c_80000c = 109,
        Limit_50000c_100000c = 111,
        Limit_100000c_200000c = 114,
        Limit_150000c_300000c = 117,
        Limit_200000c_400000c = 120,
        Limit_400000c_800000c = 124,
        Limit_500000c_1000000c = 130, 
        Any = 255
    }
}