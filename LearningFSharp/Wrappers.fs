namespace Wrappers

open Newtonsoft.Json

module json =
    
    let serializar objeto =
        JsonConvert.SerializeObject objeto
    
    let desserializar<'a> json =
        JsonConvert.DeserializeObject<'a>(json)



