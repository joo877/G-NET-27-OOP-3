namespace OPP03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01
            #region Q1
            /*
             1-Composition
             2-Association
             3-Inheritance
             4-Aggregation
             5-Dependency
             
             */
            #endregion
            #region Q02
            /*
             a- child class can access protected field from parnt. an object instance from chiled to outside can be access this field (behaivor as a private field)
             
              
      b-                            with inheritance               Vs             without inheritance 

     protected internal     access in same assembly and other                   access in same assembly only 
    private protected         access in same assembly only                      access in class only   
            


            c- sealed with class :  class cannot inhirt (can be child , cannot be parent  and an still create objects  ) 
               sealed with method :  prevent further overriding 

            d- Yes! Sealed prevents inheritance, not instantiation. You can still create objects.
             */
            #endregion
            #endregion
        }
    }
}
