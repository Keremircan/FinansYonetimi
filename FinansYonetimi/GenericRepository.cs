using System;
using System.Collections.Generic;
using System.Linq;
using FinansYonetimi;
using Microsoft.EntityFrameworkCore;

public class GenericRepository<T> where T : class
{
    private readonly FYContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(FYContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>(); // Dinamik olarak modelin DbSet'ine erişir.
    }

    public List<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Entry(entity).State = EntityState.Deleted;
        _context.SaveChanges();
    }
}
