using System;
using Xunit;
using Bageriet.Models;
using Bageriet.Controllers;
using Bageriet.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bageriet.Test
{
    public class BagerietLindahls
    {
        [TestMethod]

        public void ProductViewModelNotNull()
        {
            ProductListViewModel productList = new ProductListViewModel();

            Assert.NotNull(productList);
        }

        [TestMethod]
        public void Home_ViewmodelNotNull()
        {
            HomeViewModel homeViewModel = new HomeViewModel();


            Assert.NotNull(homeViewModel);
        }

        [TestMethod]
        public void Test2()
        {
            var modeler = new Category();
            var result = new Category();

            Assert.NotEqual(modeler, result);
        }
    }
}

