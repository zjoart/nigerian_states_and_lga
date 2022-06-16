using System.Collections.Generic;

namespace nigeria_state_and_lga.Services
{
    public interface INigeriaStateLga
    {
         List<string> GetStates();
         List<string> GetAllLga();
         List<string> GetLgaByState(string state);
    }
}
