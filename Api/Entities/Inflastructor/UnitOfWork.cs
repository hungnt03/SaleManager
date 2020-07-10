using Api.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public interface IUnitOfWork
    {
        GenericRepository<Category> CategoryRepository { get; }
        GenericRepository<Supplier> SupplierRepository { get; }
        GenericRepository<Customer> CustomerRepository { get; }
        GenericRepository<Product> ProductRepository { get; }

        GenericRepository<Discount> DiscountRepository { get; }
        void Commit();
        void Rollback();
    }
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private SecurityContext context;
        private bool disposed = false;
        private GenericRepository<Category> categoryRepository;
        private GenericRepository<Supplier> supplierRepository;
        private GenericRepository<Customer> customerRepository;
        private GenericRepository<Product> productRepository;
        private GenericRepository<Discount> discountRepository;

        public UnitOfWork(SecurityContext context)
        {
            this.context = context;
        }
        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                    this.categoryRepository = new GenericRepository<Category>(context);
                return categoryRepository;
            }
        }
        public GenericRepository<Supplier> SupplierRepository
        {
            get
            {
                if (this.supplierRepository == null)
                    this.supplierRepository = new GenericRepository<Supplier>(context);
                return supplierRepository;
            }
        }
        public GenericRepository<Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                    this.customerRepository = new GenericRepository<Customer>(context);
                return customerRepository;
            }
        }
        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                    this.productRepository = new GenericRepository<Product>(context);
                return productRepository;
            }
        }
        public GenericRepository<Discount> DiscountRepository
        {
            get
            {
                if (this.discountRepository == null)
                    this.discountRepository = new GenericRepository<Discount>(context);
                return discountRepository;
            }
        }

        GenericRepository<Category> IUnitOfWork.CategoryRepository => CategoryRepository;
        GenericRepository<Supplier> IUnitOfWork.SupplierRepository => SupplierRepository;
        GenericRepository<Product> IUnitOfWork.ProductRepository => ProductRepository;
        GenericRepository<Discount> IUnitOfWork.DiscountRepository => DiscountRepository;

        public void Commit()
        {
            context.SaveChanges();
        }
        public void Rollback()
        {
            context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
