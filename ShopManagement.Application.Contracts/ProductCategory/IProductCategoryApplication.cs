using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.Application.Contracts.ProductCategoryAgg;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        void Create(CreateProductCategory command);
        void Edit(EditProductCategory command);
        List<ProductCategoryViewModel> search(ProductCategorySerachModel searchModel);
        Domain.ProductCategoryAgg.ProductCategory GetDetails(long id);
    }
}
