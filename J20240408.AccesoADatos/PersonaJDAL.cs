using J20240408.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;


namespace J20240408.AccesoADatos
{
    public class PersonaJDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaJDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<int> Crear(PersonaJ personasJ)
        {
            _appDbContext.Add(personasJ);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaJ personasJ)
        {
            var personaJData = await _appDbContext.personasJ.FirstOrDefaultAsync(s => s.Id == personasJ.Id);
            if (personaJData != null)
            {
                personaJData.NombreJ = personasJ.NombreJ;
                personaJData.ApellidoJ = personasJ.ApellidoJ;
                personaJData.FechadeNacimientoJ = personasJ.FechadeNacimientoJ;
                _appDbContext.Update(personaJData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaJ personasJ)
        {
            var personaDData = await _appDbContext.personasJ.FirstOrDefaultAsync(s => s.Id == personasJ.Id);
            if (personaDData != null)
                _appDbContext.Remove(personaDData);
            return await _appDbContext.SaveChangesAsync();
        }


        public async Task<PersonaJ> ObtenerPorId(PersonaJ personasJ)
        {
            var personaDData = await _appDbContext.personasJ.FirstOrDefaultAsync(s => s.Id == personasJ.Id);
            if (personaDData != null)
                return personaDData;
            else
                return new PersonaJ();
        }
        public async Task<List<PersonaJ>> ObtenerPorTodos(PersonaJ personasJ)
        {
            return await _appDbContext.personasJ.ToListAsync();
        }
        public async Task<List<PersonaJ>> Buscar(PersonaJ personasJ)
        {
            var query = _appDbContext.personasJ.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personasJ.NombreJ))
            {
                query = query.Where(s => s.NombreJ.Contains(personasJ.NombreJ));
            }
            if (!string.IsNullOrWhiteSpace(personasJ.ApellidoJ))
            {
                query = query.Where(s => s.ApellidoJ.Contains(personasJ.ApellidoJ));
            }
            return await query.ToListAsync();
        }
    }
}
