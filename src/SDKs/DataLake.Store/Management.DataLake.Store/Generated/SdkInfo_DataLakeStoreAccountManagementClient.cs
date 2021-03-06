
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_DataLakeStoreAccountManagementClient
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("DataLakeStore", "Account", "2016-11-01"),
                new Tuple<string, string, string>("DataLakeStore", "FirewallRules", "2016-11-01"),
                new Tuple<string, string, string>("DataLakeStore", "Locations", "2016-11-01"),
                new Tuple<string, string, string>("DataLakeStore", "Operations", "2016-11-01"),
                new Tuple<string, string, string>("DataLakeStore", "TrustedIdProviders", "2016-11-01"),
            }.AsEnumerable();
        }
    }
}
