// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.
using System.Collections.Generic;
using Newtonsoft.Json;
using Kentico.Kontent.Management.Models.Items;

namespace KenticoKontentModels
{
    public partial class MovieImport : Movie
    {
        [JsonProperty("listed_in")]
        public new IEnumerable<TaxonomyTermIdentifier> ListedIn { get; set; }
        [JsonProperty("rating")]
        public new IEnumerable<MultipleChoiceOptionIdentifier> Rating { get; set; }
    }
}