using Newtonsoft.Json;
using System.Collections.Generic;

namespace EDIParserAPIService.Models

{
    internal class EDI
    {
        public string id { get; set; }

       
    
    public class B4
        {
            [JsonProperty("ContainerID")]
            public string ContainerID { get; set; }
            [JsonProperty("Special_Handling_Code")]
            public string Special_Handling_Code { get; set; }
            [JsonProperty("Inquery_Request_No")]
            public string Inquery_Request_No { get; set; }
            [JsonProperty("Shipement_Status_Code")]
            public string Shipement_Status_Code { get; set; }
            [JsonProperty("ReleaseDate")]
            public string ReleaseDate { get; set; }
            [JsonProperty("ReleaseTime")]
            public string ReleaseTime { get; set; }

            [JsonProperty("Status_Location")]
            public string Status_Location { get; set; }
            [JsonProperty("Equipment_Initial")]
            public string Equipment_Initial { get; set; }
            [JsonProperty("Equipment_Number")]
            public string Equipment_Number { get; set; }
            [JsonProperty("Equipment_Status_Code")]
            public string Equipment_Status_Code { get; set; }

            [JsonProperty("Equipment_Type")]
            public string Equipment_Type { get; set; }
            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }

        public class DTM
        {
            [JsonProperty("DTQ")]
            public string DTQ { get; set; }

            [JsonProperty("Date")]
            public string Date { get; set; }

            [JsonProperty("Time")]
            public string Time { get; set; }

            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);

            }
        }
        public class GE
        {
            [JsonProperty("Number_Transaction_Set")]
            public string Number_Transaction_Set { get; set; }

            [JsonProperty("GCN")]
            public string GCN { get; set; }
            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }

        public class GS
        {
            [JsonProperty("Functional_Identifier_Code")]
            public string Functional_Identifier_Code { get; set; }
            [JsonProperty("Sender_code")]
            public string Sender_code { get; set; }
            [JsonProperty("Reciever_Code")]
            public string Reciever_Code { get; set; }
            [JsonProperty("GroupDate")]
            public string Date { get; set; }
            [JsonProperty("GorupTime")]
            public string Time { get; set; }
            [JsonProperty("GCN")]
            public string GCN { get; set; }
            [JsonProperty("Agency_Code")]
            public string Agency_Code { get; set; }

            [JsonProperty("Version")]
            public string Version { get; set; }
            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }
        internal class IEA
        {
            public string IEA01 { get; set; }
            public string IEA02 { get; set; }
        }

        public class ISA
        {
            [JsonProperty("SenderID")]
            public string SenderID { get; set; }
            [JsonProperty("RecieverID")]
            public string RecieverID { get; set; }
            [JsonProperty("Date")]
            public string Date { get; set; }

            [JsonProperty("Time")]
            public string Time { get; set; }

            [JsonProperty("ICSID")]
            public string ICSID { get; set; }
            [JsonProperty("InterchangeVersion")]
            public string InterchangeVersion { get; set; }
            [JsonProperty("ICN")]
            public string ICN { get; set; }
            [JsonProperty("Acknow_request")]
            public string Acknow_request { get; set; }
            [JsonProperty("Test_Indicator")]
            public string Test_Indicator { get; set; }
            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }

        }
        public class N9
        {
            [JsonProperty("Ref_Id_Qualifier")]

            public string Ref_Id_Qualifier { get; set; }
            [JsonProperty("Ref_Id")]
            public string Ref_Id { get; set; }

            [JsonProperty("Fees")]
            public string Fees { get; set; }

            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }

        public class Q2
        {
            [JsonProperty("Vessel_Code")]
            public string Vessel_Code { get; set; }
            [JsonProperty("Country_Code")]
            public string Country_Code { get; set; }
            [JsonProperty("voyage_Number")]
            public string voyage_Number { get; set; }
            [JsonProperty("Vessel_Name")]
            public string Vessel_Name { get; set; }
            [JsonProperty("Weight")]
            public string Weight { get; set; }
            [JsonProperty("Weight_Qualifier")]
            public string Weight_Qualifier { get; set; }
            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }
        public class R4
        {
            [JsonProperty("Port_Function_Code")]
            public string Port_Function_Code { get; set; }
            [JsonProperty("Location_Qualifier")]
            public string Location_Qualifier { get; set; }
            [JsonProperty("Location_Identifier")]
            public string Location_Identifier { get; set; }
            [JsonProperty("Port_Name")]
            public string Port_Name { get; set; }

            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }
        public class SE
        {
            [JsonProperty("Number_of_Segments")]
            public string Number_of_Segments { get; set; }

            [JsonProperty("Transaction_Set_Control_Number")]
            public string Transaction_Set_Control_Number { get; set; }
            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }
        public class SG
        {
            [JsonProperty("Shipment_Status_Code")]
            public string Shipment_Status_Code { get; set; }
            [JsonProperty("Date")]
            public string Date { get; set; }

            [JsonProperty("Time")]
            public string Time { get; set; }

            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }

    }
}