using nigeria_state_and_lga.enums;
using nigeria_state_and_lga.Models;
using System;
using System.Collections.Generic;

namespace nigeria_state_and_lga.Services
{
    public class NigeriaStateLga : INigeriaStateLga
    {
        // get all states in nigeria
        public List<string> GetStates()
        {
            NigerianStatesAndLGA.allStates.Sort();  
            return NigerianStatesAndLGA.allStates;
        }

        // get all lgas in nigeria
        public List<string> GetAllLga()
        {
            NigerianStatesAndLGA.allLgas.Sort();
            return NigerianStatesAndLGA.allLgas;
        }

        // get lga by state

        public List<string> GetLgaByState(string state)
        {
           // if(state.isNu)
            var validState = Enum.TryParse<NigerianStates>(state, out NigerianStates value);
            if (validState)
            {
                switch (value)
                {
                    case NigerianStates.abia:
                        return NigerianStatesAndLGA.abiaLGAs;
                    case NigerianStates.adamawa:
                        return NigerianStatesAndLGA.adamawaLGAs;
                    case NigerianStates.akwaIbom:
                        return NigerianStatesAndLGA.akwaIbomLGAs;
                    case NigerianStates.anambra:
                        return NigerianStatesAndLGA.anambraLGAs;
                    case NigerianStates.bauchi:
                        return NigerianStatesAndLGA.bauchiLGAs;
                    case NigerianStates.bayelsa:
                        return NigerianStatesAndLGA.bayelsaLGAs;
                    case NigerianStates.benue:
                        return NigerianStatesAndLGA.benueLGAs;
                    case NigerianStates.borno:
                        return NigerianStatesAndLGA.bornoLGAs;
                    case NigerianStates.crossRiver:
                        return NigerianStatesAndLGA.crossRiverLGAs;
                    case NigerianStates.delta:
                        return NigerianStatesAndLGA.deltaLGAs;
                    case NigerianStates.ebonyi:
                        return NigerianStatesAndLGA.ebonyiLGAs;
                    case NigerianStates.edo:
                        return NigerianStatesAndLGA.edoLGAs;
                    case NigerianStates.ekiti:
                        return NigerianStatesAndLGA.ekitiLGAs;
                    case NigerianStates.enugu:
                        return NigerianStatesAndLGA.enuguLGAs;
                    case NigerianStates.gombe:
                        return NigerianStatesAndLGA.gombeLGAs;
                    case NigerianStates.imo:
                        return NigerianStatesAndLGA.imoLGAs;
                    case NigerianStates.jigawa:
                        return NigerianStatesAndLGA.jigawaLGAs;
                    case NigerianStates.kaduna:
                        return NigerianStatesAndLGA.kadunaLGAs;
                    case NigerianStates.kano:
                        return NigerianStatesAndLGA.kanoLGAs;
                    case NigerianStates.katsina:
                        return NigerianStatesAndLGA.katsinaLGAs;
                    case NigerianStates.kebbi:
                        return NigerianStatesAndLGA.kebbiLGAs;
                    case NigerianStates.kogi:
                        return NigerianStatesAndLGA.kogiLGAs;
                    case NigerianStates.kwara:
                        return NigerianStatesAndLGA.kwaraLGAs;
                    case NigerianStates.lagos:
                        return NigerianStatesAndLGA.lagosLGAs;
                    case NigerianStates.nasarawa:
                        return NigerianStatesAndLGA.nasarawaLGAs;
                    case NigerianStates.niger:
                        return NigerianStatesAndLGA.nigerLGAs;
                    case NigerianStates.ogun:
                        return NigerianStatesAndLGA.ogunLGAs;
                    case NigerianStates.ondo:
                        return NigerianStatesAndLGA.ondoLGAs;
                    case NigerianStates.osun:
                        return NigerianStatesAndLGA.osunLGAs;
                    case NigerianStates.oyo:
                        return NigerianStatesAndLGA.oyoLGAs;
                    case NigerianStates.plateau:
                        return NigerianStatesAndLGA.plateauLGAs;
                    case NigerianStates.rivers:
                        return NigerianStatesAndLGA.riversLGAs;
                    case NigerianStates.sokoto:
                        return NigerianStatesAndLGA.sokotoLGAs;
                    case NigerianStates.taraba:
                        return NigerianStatesAndLGA.tarabaLGAs;
                    case NigerianStates.yobe:
                        return NigerianStatesAndLGA.yobeLGAs;
                    case NigerianStates.zamfara:
                        return NigerianStatesAndLGA.zamfaraLGAs;
                    case NigerianStates.fct:
                        return NigerianStatesAndLGA.abujaLGAs;
                    default:
                        return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
