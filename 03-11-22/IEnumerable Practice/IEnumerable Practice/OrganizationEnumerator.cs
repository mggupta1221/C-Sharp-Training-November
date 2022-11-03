using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Practice
{
    public class OrganizationEnumerator : IEnumerator  //As iENumerator is interface we cannot create object of it so we are implementing IEnumerator to another class and using object of that class to return
    {
        Organization organizationCollection = new Organization();  //Access Organization Collection to iterate over it
        int currentIndex;  //To move index
        Employee currentEmployee;  //to return current employee


        public OrganizationEnumerator(Organization org)
        {
            organizationCollection = org;
            currentIndex = -1;
        }


        public object Current
        {
            get { return currentEmployee; }
        }

        public bool MoveNext()
        {

            if (++currentIndex >= organizationCollection.Count) //if index is out of bound
                return false;
            else
            {
                currentEmployee = organizationCollection[currentIndex];
                return true;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
