﻿using Volo.Abp.Modularity;

namespace ABP.ProductManagement;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class ProductManagementApplicationTestBase<TStartupModule> : ProductManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
