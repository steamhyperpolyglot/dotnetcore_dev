using System;

namespace PacktLibrary
{
    public class Animal : IDisposable
    {
        public Animal()
        {
            // Allocate unmanaged resource
        }

        ~Animal()
        {
            if (disposed) return;
            Dispose(false);
        }

        bool disposed = false;  // have resources been released?

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                // deallocate any other *managed* resources
            }
            disposed = true;
        }
    }
}