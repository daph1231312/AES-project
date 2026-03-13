using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balls
{
    public class AesResult    //this class is just a container to hold the result data in one place.
                              //we use it to pass around important info in one place. One AesResult object instead of 5 variables.
    {
        public string OriginalText { get; set; }   //the original text the user typed

        public string ResultText { get; set; }     //the result text after encrypting or decrypting

        public string Mode {  get; set; }          //the chosen mode

        public int KeyLength { get; set; }         //the chosen key length

        public string Operation { get; set; }      //either encryption or decryption chosen by the user

       /* public override string ToString()        Normally ToString() just prints the class name — we override it to print useful info instead
                                                   This is called automatically when you do: ResultTextbox.Text = result.ToString()
        {                                          wont use it in this code
            return $"Operation : {Operation}\n" +
                  $"Mode      : {Mode}\n" +
                  $"Key Length: {KeyLength} bits\n" +
                  $"Input     : {OriginalText}\n" +
                  $"Output    : {ResultText}";
        }
       */
    }
}
