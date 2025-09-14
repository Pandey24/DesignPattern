// Entity
class Employee
{
    int Id;
    string Name;
}

// Repository Interface (contract)
interface IRepository<T>
{
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    T GetById(int id);
    IEnumerable<T> GetAll();
}

// Concrete Repository (with EF or InMemory)
class Repository<T> : IRepository<T>
{
    DbContext _context;
    DbSet<T> _dbSet;

    Repository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();   // EF chooses correct table
    }

    void Add(T entity) => _dbSet.Add(entity);
    void Update(T entity) => _dbSet.Update(entity);
    void Delete(int id) => { ... }
    T GetById(int id) => _dbSet.Find(id);
    IEnumerable<T> GetAll() => _dbSet.ToList();
}

// Usage (in Service or Controller)
var empRepo = new Repository<Employee>(dbContext);
empRepo.Add(new Employee { Id = 1, Name = "Suraj" });
var allEmployees = empRepo.GetAll();
