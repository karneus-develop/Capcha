﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capcha
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Karneus_PlanerEntities : DbContext
    {
        public Karneus_PlanerEntities()
            : base("name=Karneus_PlanerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountData> AccountData { get; set; }
        public virtual DbSet<Desc> Desc { get; set; }
        public virtual DbSet<Note_Table> Note_Table { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<RegistDB> RegistDB { get; set; }
        public virtual DbSet<Spisok> Spisok { get; set; }
    }
}
