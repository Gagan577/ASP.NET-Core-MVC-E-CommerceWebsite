using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Computer", Description = "Bilgisayar, Donanım Ürünleri"},
                new Category(){ Name = "Camera", Description = "Fotoğraf, Kamera Ürünleri"},
                new Category(){ Name = "Phone", Description = "Telefon Ürünleri"},
                new Category(){ Name = "TV", Description = "TV, Ses, Görüntü Ürünleri"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name = "Macbook Air MQD32TU/A",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =4799 , Stock =1 , IsApproved =false , CategoryId = 1,IsHome = false,Image = "apple-mqd32tu-a.jpg"},

                new Product(){ Name = "Canon EOS 2000D",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =2299 , Stock =1 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "canon-eos-2000d.jpg"},

                new Product(){ Name = "Huawei P30 Pro",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =6799 , Stock =1 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "huawei-p30-pro.jpg"},

                new Product(){ Name = "Samsung UE-55NU8000",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =5899 , Stock =1 , IsApproved =true , CategoryId = 4,IsHome = true,Image = "samsung-55nu8000.jpg"},

                new Product(){ Name = "Samsung Galaxy S10 Plus",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =6399 , Stock =1 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "samsung-galaxy-s10-plus.jpg"},

                new Product(){ Name = "Macbook Pro MPXR2TU/A",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =7999 , Stock =1 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "macbook-pro-mpxr2tu-a.png"},

                new Product(){ Name = "Lenovo Yoga 530 81EK00DUTX",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =5399 , Stock =1 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "lenovo-yoga-530-81ek00dutx.jpg"},

                new Product(){ Name = "Nikon D3500",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =2399 , Stock =1 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "nikon-d3500.jpg"},

                new Product(){ Name = "iPhone X",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =7899 , Stock =1 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "iphone-x.jpg"},

                new Product(){ Name = "LG 55UK6470PLC",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =4099 , Stock =1 , IsApproved =true , CategoryId = 4,IsHome = true,Image = "lg-55uk6470plc.jpg"},

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}