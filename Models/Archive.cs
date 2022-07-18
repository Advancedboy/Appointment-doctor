using System.Collections.Generic;

namespace AppointmentDoctor.Models
{
    public static class Archive
    {
        private static List<PatientResponse> responses = new List<PatientResponse>();

        public static IEnumerable<PatientResponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(PatientResponse response)
        {
            responses.Add(response);
        }
    }
}
