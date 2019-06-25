using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCompanyHRSystem
{
    class Absence
    {
        int absenceID;
        String absenceType;
        String absenceReason;
        String absenceNotes;
        Boolean ssp;
        Boolean workRelatedAccident;
        Boolean doctorsNote;
        DateTime doctorsNoteExpiresOn;
        Boolean selfCert;
        DateTime absenceStarted;
        DateTime absenceEnded;
        String status;
    }
}
