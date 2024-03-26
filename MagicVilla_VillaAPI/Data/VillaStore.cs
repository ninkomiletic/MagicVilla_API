using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
                new VillaDTO { Id = 1, Name = "PoolVilla", Occupancy = 100, Sqft = 3}, 
                new VillaDTO { Id = 2, Name = "BeachVilla", Occupancy = 300, Sqft = 4 } };
    }
}
