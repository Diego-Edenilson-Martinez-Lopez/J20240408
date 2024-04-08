using J20240408.AccesoADatos;
using J20240408.EntidadesDeNegocio;

namespace J20240408.LogicaDeNegocio
{
    public class PersonaJBL
    {
        readonly PersonaJDAL _personaJDAL;
        public PersonaJBL(PersonaJDAL personaJDAL)
        {
            _personaJDAL = personaJDAL;
        }
        public async Task<int> Crear(PersonaJ personasJ)
        {

            return await _personaJDAL.Crear(personasJ);
        }
        public async Task<int> Modificar(PersonaJ personaJ)
        {

            return await _personaJDAL.Modificar(personaJ);
        }
        public async Task<int> Eliminar(PersonaJ personasJ)
        {

            return await _personaJDAL.Eliminar(personasJ);
        }
        public async Task<PersonaJ> ObtenerPorId(PersonaJ personasJ)
        {
            return await _personaJDAL.ObtenerPorId(personasJ);
        }
        public async Task<List<PersonaJ>> ObtenerPorTodos(PersonaJ personasJ)
        {
            return await _personaJDAL.ObtenerPorTodos(personasJ);
        }
        public async Task<List<PersonaJ>> Buscar(PersonaJ personasJ)
        {
            return await _personaJDAL.Buscar(personasJ);
        }
    }
}
