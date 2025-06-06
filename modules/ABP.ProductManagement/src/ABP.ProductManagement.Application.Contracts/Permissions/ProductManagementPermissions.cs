﻿using Volo.Abp.Reflection;

namespace ABP.ProductManagement.Permissions;

public class ProductManagementPermissions
{
    public const string GroupName = "ProductManagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductManagementPermissions));
    }
}
