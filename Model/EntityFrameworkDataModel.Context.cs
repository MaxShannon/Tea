﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntityFrameworkDataModelContainer : DbContext
    {
        public EntityFrameworkDataModelContainer()
            : base("name=EntityFrameworkDataModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<OrderInfo> OrderInfoSet { get; set; }
        public virtual DbSet<CargoInfo> CargoInfoSet { get; set; }
        public virtual DbSet<GoodsInfo> GoodsInfoSet { get; set; }
        public virtual DbSet<UserPrivileges> UserPrivilegesSet { get; set; }
        public virtual DbSet<CargoLogInfo> CargoLogInfoSet { get; set; }
        public virtual DbSet<ProjectInfo> ProjectInfoSet { get; set; }
        public virtual DbSet<ApplyInfo> ApplyInfo { get; set; }
        public virtual DbSet<ApplyCargoInfo> ApplyCargoInfo { get; set; }
        public virtual DbSet<SupplyInfo> SupplyInfoSet { get; set; }
        public virtual DbSet<CategoryInfo> CategoryInfoSet { get; set; }
        public virtual DbSet<SupplyCategoryInfo> SupplyCategoryInfoSet { get; set; }
    }
}
