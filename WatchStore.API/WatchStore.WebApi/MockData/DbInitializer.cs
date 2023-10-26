using Microsoft.EntityFrameworkCore;
using WatchStore.WebApi.Entities;

namespace WatchStore.WebApi.MockData;

internal class DbInitializer
{
    private readonly ModelBuilder _modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        SeedProducts();
        SeedRoles();
        SeedUsers();
        SeedCarts();
        SeedCustomers();
    }

    private void SeedProducts()
    {
        _modelBuilder.Entity<Product>().HasData(
            new List<Product> {
            new()
            {
                Id = 1,
                Name = "Classic Silver Watch",
                Description = "Elegant silver watch with a leather strap.",
                ImgUrl =
                    "https://idom.kiev.ua/image/Watch/Watch-Ultra/Apple-Watch-Series-Ultra-ocean-midnight-photo.jpg",
                Price = 99.99m,
                TotalAmount = 500,
                Rating = 4.0m
            },
            new()
            {
                Id = 2,
                Name = "Sporty Chronograph Watch",
                Description = "Water-resistant chronograph watch for sports enthusiasts.",
                ImgUrl = "https://m.media-amazon.com/images/I/71VjM5LOeYL._AC_UY780_.jpg",
                Price = 129.99m,
                TotalAmount = 20,
                Rating = 4.8m
            },
            new()
            {
                Id = 3,
                Name = "Rose Gold Fashion Watch",
                Description = "Trendy rose gold watch with a minimalist design.",
                ImgUrl =
                    "https://www.linjer.co/cdn/shop/products/linjer-classic-watch-38-gunmetal-tan-1-front_grande.jpg?v=1602577160",
                Price = 79.99m,
                TotalAmount = 400,
                Rating = 3.4m
            },
            new()
            {
                Id = 4,
                Name = "Digital Smartwatch",
                Description = "Smartwatch with fitness tracking and notifications.",
                ImgUrl =
                    "https://images.samsung.com/is/image/samsung/p6pim/ua/2307/gallery/ua-galaxy-watch6-r935-sm-r930nzeasek-537479860?$650_519_PNG$",
                Price = 149.99m,
                TotalAmount = 40,
                Rating = 4.6m
            },
            new()
            {
                Id = 5,
                Name = "Luxury Gold Watch",
                Description = "Exquisite gold watch with diamond-studded dial.",
                ImgUrl =
                    "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/ML733_VW_34FR+watch-case-41-stainless-gold-s9_VW_34FR+watch-face-41-stainless-gold-s9_VW_34FR?wid=2000&hei=2000&fmt=png-alpha&.v=1694507905569",
                Price = 299.99m,
                TotalAmount = 15,
                Rating = 4.9m
            },
            new()
            {
                Id = 6,
                Name = "Vintage Leather Watch",
                Description = "Classic leather watch for a timeless style.",
                ImgUrl =
                    "https://www-konga-com-res.cloudinary.com/w_400,f_auto,fl_lossy,dpr_3.0,q_auto/media/catalog/product/U/O/92910_1666897463.jpg",
                Price = 89.99m,
                TotalAmount = 200,
                Rating = 4.2m
            },
            new()
            {
                Id = 7,
                Name = "Diving Sports Watch",
                Description = "Durable sports watch for diving enthusiasts.",
                ImgUrl = "https://fossil.scene7.com/is/image/FossilPartners/FS5384_main?$sfcc_fos_medium$",
                Price = 159.99m,
                TotalAmount = 30,
                Rating = 4.5m
            },
            new()
            {
                Id = 8,
                Name = "Sleek Stainless Steel Watch",
                Description = "Stainless steel watch with a modern design.",
                ImgUrl = "https://m.media-amazon.com/images/I/81nC4u9eYfL._AC_UY1000_.jpg",
                Price = 109.99m,
                TotalAmount = 150,
                Rating = 4.3m
            },
            new()
            {
                Id = 9,
                Name = "Fitness Tracker Bracelet",
                Description = "Bracelet with built-in fitness tracking features.",
                ImgUrl =
                    "https://img.piaget.com/new-product-banner-normal-2/2cbb5d5c3aa87deb32fa85058422982dfec2bfb2.jpg",
                Price = 49.99m,
                TotalAmount = 100,
                Rating = 4.1m
            },
            new()
            {
                Id = 10,
                Name = "Wooden Dial Watch",
                Description = "Watch with a unique wooden dial for nature lovers.",
                ImgUrl =
                    "https://www.raymond-weil.us/wp-content/uploads/2023/04/RW_toccata_5385-pc5-00859_rvb_700x860px_72dpi-1.png",
                Price = 69.99m,
                TotalAmount = 80,
                Rating = 4.7m
            },
            new()
            {
                Id = 11,
                Name = "Smart Fitness Watch",
                Description = "Smartwatch with advanced fitness tracking capabilities.",
                ImgUrl = "https://www.vaerwatches.com/cdn/shop/files/GMT-Home-Collection.jpg?v=1678902341&width=1000",
                Price = 179.99m,
                TotalAmount = 25,
                Rating = 4.6m
            },
            new()
            {
                Id = 12,
                Name = "Casual Canvas Strap Watch",
                Description = "Casual watch with a comfortable canvas strap.",
                ImgUrl = "https://www.vaerwatches.com/cdn/shop/files/G5-Batman-QR-WFL-BLK.jpg?v=1684430729&width=1200",
                Price = 59.99m,
                TotalAmount = 120,
                Rating = 4.0m
            },
            new()
            {
                Id = 13,
                Name = "Diamond Encrusted Watch",
                Description = "Luxurious watch with diamond encrusted details.",
                ImgUrl =
                    "https://www.anguscoote.com.au/content/products/citizen-mens-quartz-watch-5065022-141566.jpg?width=1200&height=630&fit=bounds",
                Price = 499.99m,
                TotalAmount = 10,
                Rating = 4.9m
            },
            new()
            {
                Id = 14,
                Name = "Rugged Outdoor Watch",
                Description = "Durable watch designed for outdoor activities.",
                ImgUrl =
                    "https://www.prouds.com.au/content/products/g-shock-watch-by-casio-5149229-140528.jpg?canvas=1:1&auto=webp&optimize=high&width=375",
                Price = 129.99m,
                TotalAmount = 35,
                Rating = 4.4m
            },
            new()
            {
                Id = 15,
                Name = "Elegant Ceramic Watch",
                Description = "Elegantly designed watch with a ceramic strap.",
                ImgUrl =
                    "https://i02.appmifile.com/619_operator_in/13/05/2021/f1781d7f24bd880a489a6a72088a261c!800x800!85.png",
                Price = 199.99m,
                TotalAmount = 18,
                Rating = 4.8m
            },
            new()
            {
                Id = 16,
                Name = "Pocket Watch",
                Description = "Classic pocket watch with a vintage charm.",
                ImgUrl =
                    "https://www.watchportal.com.ph/cdn/shop/products/1_d9fb14cf-cf36-4ee4-a513-7ecded3a1c4c.jpg?v=1600303384",
                Price = 79.99m,
                TotalAmount = 60,
                Rating = 4.3m
            },
            new()
            {
                Id = 17,
                Name = "Minimalist Design Watch",
                Description = "Watch with a minimalist design for a clean look.",
                ImgUrl = "https://timex.eu/cdn/shop/products/TW2V42700.png?v=1687315799&width=990",
                Price = 69.99m,
                TotalAmount = 90,
                Rating = 4.2m
            },
            new()
            {
                Id = 18,
                Name = "Aviator Pilot Watch",
                Description = "Pilot watch with aviation-inspired features.",
                ImgUrl = "https://www.watches.com/cdn/shop/products/Timex-TW2V70100_1800x1800.jpg?v=1678413063",
                Price = 139.99m,
                TotalAmount = 25,
                Rating = 4.5m
            },
            new()
            {
                Id = 19,
                Name = "Smart Ring",
                Description = "Ring with smart features like notifications and health tracking.",
                ImgUrl = "https://staticimg.titan.co.in/Sonata/Catalog/7140WL02_1.jpg?pView=listing",
                Price = 89.99m,
                TotalAmount = 70,
                Rating = 4.1m
            },
            new()
            {
                Id = 20,
                Name = "Digital Fitness Band",
                Description = "Fitness band with a digital display for activity tracking.",
                ImgUrl =
                    "https://images-static.nykaa.com/media/catalog/product/8/7/875c3d17140NL05_1.jpg?tr=w-500,pr-true",
                Price = 39.99m,
                TotalAmount = 150,
                Rating = 4.0m
            },
            new()
            {
                Id = 21,
                Name = "Antique Brass Pocket Watch",
                Description = "Antique pocket watch with a brass finish.",
                ImgUrl =
                    "https://www.chanel.com/images//t_one////q_auto:good,f_auto,fl_lossy,dpr_1.2/w_1920/j12-interstellar-watch-38-mm-black-black-ceramic-steel-diamond-packshot-default-h7989-9528001626142.jpg",
                Price = 119.99m,
                TotalAmount = 30,
                Rating = 4.6m
            },
            new()
            {
                Id = 22,
                Name = "Solar-Powered Watch",
                Description = "Environmentally friendly watch powered by solar energy.",
                ImgUrl =
                    "https://www.hublot.com/sites/default/files/styles/homepage_hero_image_mobile/public/2023-03/MP-13-Tourbillon-Bi-Axis-Retrograde-44-mm-homepage.png?itok=EU0Daw2P",
                Price = 149.99m,
                TotalAmount = 22,
                Rating = 4.7m
            },
            new()
            {
                Id = 23,
                Name = "Stylish Mesh Strap Watch",
                Description = "Watch with a stylish mesh strap for a modern look.",
                ImgUrl =
                    "https://www.boat-lifestyle.com/cdn/shop/products/a09a67f0-75bd-42b8-8f0d-58ffad51e03b_600x.png?v=1625045372",
                Price = 109.99m,
                TotalAmount = 50,
                Rating = 4.2m
            },
            new()
            {
                Id = 24,
                Name = "Digital Sports Watch",
                Description = "Sports watch with digital display and multiple functions.",
                ImgUrl =
                    "https://cdn.opstatics.com/store/20170907/assets/images/events/2021/03/watches/en/common/1920/kv/kv-2.png",
                Price = 79.99m,
                TotalAmount = 65,
                Rating = 4.3m
            },
            new()
            {
                Id = 25,
                Name = "Sapphire Crystal Watch",
                Description = "Watch with a scratch-resistant sapphire crystal.",
                ImgUrl = "https://m.media-amazon.com/images/I/718ndu+NQnL._AC_SL1500_.jpg",
                Price = 199.99m,
                TotalAmount = 18,
                Rating = 4.8m
            }
            }
        );
    }

    private void SeedRoles()
    {
        _modelBuilder.Entity<Role>().HasData(
            new List<Role>
            {
                new() {
                    Id = 1, Name = "Administrator"
                }
            }
            );
    }
    
    
    private void SeedUsers()
    {
        _modelBuilder.Entity<User>().HasData(
            new List<User>
            {
                new()
                {
                    Id = 1,
                    Login = "admin",
                    Password = "admin",
                    RoleId = 1,
                }
            }
        );
    }
    
    private void SeedCarts()
    {
        _modelBuilder.Entity<Cart>().HasData(
            new List<Cart>
            {
                new()
                {
                    Id = 1,
                }
            }
        );
    }
        
    private void SeedCustomers()
    {
        _modelBuilder.Entity<Customer>().HasData(
            new List<Customer>
            {
                new()
                {
                    Id = 1,
                    Name = "User",
                    Surname = "Test",
                    PhoneNumber = "",
                    DeliveryAddress = "Test delivery address #112233",
                    CartId = 1,
                    Orders = null,

                }
            }
        );
    }
}
