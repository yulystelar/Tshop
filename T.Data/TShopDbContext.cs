using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.Model.Models;

namespace T.Data
{
    class TShopDbContext: DbContext
    {
        public TShopDbContext(): base("TShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> footers { set; get; }

        /*public DbSet<AppSetting> AppSettings { set; get; }
        public DbSet<Cabinet> Cabinets { set; get; }
        public DbSet<CabinetProductInfo> CabinetProductInfos { set; get; }
        public DbSet<City> Citys { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Dictionary> Dictionarys { set; get; }
        public DbSet<Document> Documents { set; get; }
        public DbSet<InOut> InOuts { set; get; }
        public DbSet<Inventory> Inventorys { set; get; }
        public DbSet<Language> Languages { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Receiving> Receivings { set; get; }
        public DbSet<ReceivingDetail> ReceivingDetails { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<RoleDetail> RoleDetails { set; get; }
        public DbSet<RoleFunction> RoleFunctions { set; get; }
        public DbSet<RoleMenu> RoleMenus { set; get; }
        public DbSet<RoleMenuFunction> RoleMenuFunctions { set; get; }
        public DbSet<selfworks> selfworkss { set; get; }
        public DbSet<Unit> Units { set; get; }
        public DbSet<UserDetail> UserDetails { set; get; }
        public DbSet<Users> Userss { set; get; }
        public DbSet<UserSettingDetail> UserSettingDetails { set; get; }
        public DbSet<UserSettings> UserSettingss { set; get; }
        public DbSet<Ward> Wards { set; get; }
        public DbSet<Warehouse> Warehouses { set; get; }
        public DbSet<WarehouseDetail> WarehouseDetails { set; get; }
        public DbSet<WarehouseLocation> WarehouseLocations { set; get; }*/


    }
}
