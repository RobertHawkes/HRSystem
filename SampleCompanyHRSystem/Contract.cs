using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCompanyHRSystem
{
    class Contract
    {
        int contractID;
        DateTime employmentStartedOn;
        DateTime employmentEndedOn;
        String employmentType;
        int hoursPerWeek;
        int grade;
        decimal salary;
        String taxCode;
        String payMethod;

        //Boolean statementOfEmploymentRequired; //Should be moved into Contract

        int jobPositionID;

    }
}
