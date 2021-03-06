// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace MLNET_kontent_taxonomy_appML.Model
{
    public class ModelInput
    {
        [ColumnName("show_id"), LoadColumn(0)]
        public float Show_id { get; set; }


        [ColumnName("type"), LoadColumn(1)]
        public string Type { get; set; }


        [ColumnName("title"), LoadColumn(2)]
        public string Title { get; set; }


        [ColumnName("release_year"), LoadColumn(3)]
        public float Release_year { get; set; }


        [ColumnName("rating"), LoadColumn(4)]
        public string Rating { get; set; }


        [ColumnName("duration"), LoadColumn(5)]
        public string Duration { get; set; }


        [ColumnName("listed_in"), LoadColumn(6)]
        public string Listed_in { get; set; }


        [ColumnName("description"), LoadColumn(7)]
        public string Description { get; set; }


    }
}
