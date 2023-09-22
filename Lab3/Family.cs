using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Family
    {
        List<Person> familyList  ;
        public Family()
        {
            familyList =new List<Person>();
        }

        public void AddMember(Person member)
        {
            familyList.Add(member);
        }
        public Person GetOldestMember()
        {
            if (familyList.Count == 0)
            {
                return null;
            }
            return  familyList.OrderByDescending(p => p.Age).First();
        }
        //get people in alphabetic order
        List<Person> GPIAO()
        {

            return familyList.
                Where(p => p.Age > 30).
                OrderBy(a => a.Name).ToList(); 
        }
    }
}
