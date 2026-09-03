namespace AssignmentOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical questions
            //Question1
            //a-copy struct
            //struct is value type
            //copy the values of attributes
            // modification after copying the original variable to copied variable in struct by one of variables doesn't affect the other variable
            //each variable is independent
            //has its own box in stack

            //b-copy class
            //class is reference type
            //copy the reference of object
            // modification after copying the original variable to copied variable in struct by one of variables affect the other variable
            //each variable is dependent
            //both variables point to the same object in heap

            //Question2
            //a-three problems without Encapsulation
            //1- no data control and no validation
            //2-no maintainance(modifiaction in more than place)
            //3-no read only /write only(access and print directly)

            //b-enhancement with encapsulation
            //1-put validation on attributes
            //2- maintain and refactor in one place 
            //3- read only or write only
            #endregion
            #region Practical Questions
            //copying struct
            //DeliveryAddress originalAddress = new DeliveryAddress("Cairo", "ElTahrir", 5);
            //DeliveryAddress copiedAddress = originalAddress;
            //Console.WriteLine("Copying DeliveryAdress..........");
            //Console.WriteLine("Before Modification");
            //Console.WriteLine($"originalAddress:{originalAddress.street}");
            //Console.WriteLine($"copiedAddress:{copiedAddress.street}");
            //copiedAddress.street = "Orabi";
            //Console.WriteLine("======================================");
            //Console.WriteLine("After Modification");
            //Console.WriteLine($"originalAddress:{originalAddress.street}");//ElTahrir->not change
            //Console.WriteLine($"copiedAddress:{copiedAddress.street}"); //Orabi
            #endregion
        }
    }
}
