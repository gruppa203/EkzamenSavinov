﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ЭкзаменСавинов.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Bd_SavinovEntities : DbContext
    {
        public Bd_SavinovEntities()
            : base("name=Bd_SavinovEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        private static Bd_SavinovEntities _context;
        public static Bd_SavinovEntities GetContext()
        {
            if (_context == null)
                _context = new Bd_SavinovEntities();
            return _context;
        }

        public virtual DbSet<КатегорииТоваров> КатегорииТоваров { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Роли> Роли { get; set; }
        public virtual DbSet<Товары> Товары { get; set; }
    }
}
