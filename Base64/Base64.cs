using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64
{
    public class Base64
    {
        public static string MyBase64Encode(string s)
        {
            var bits = string.Empty;
            foreach (var character in s)
            {
                bits += Convert.ToString(character, 2).PadLeft(8, '0');
            }

            string base64 = string.Empty;

            const byte threeOctets = 24;

            int j = 0;
            for (int ii = 0; ii < bits.Length / threeOctets + (bits.Length % threeOctets > 0 ? 1 : 0); ii++)
            {
                string threeOctectsBits = j * threeOctets + threeOctets < bits.Length ?
                    bits.Substring(j * threeOctets, threeOctets) : bits.Substring(j * threeOctets);

                const byte sexTets = 6;
                int k = 0;

                for (int jj = 0;
                    jj < threeOctectsBits.Length / sexTets + (threeOctectsBits.Length % sexTets > 0 ? 1 : 0);
                    jj++)
                {
                    string sixBits = k * sexTets + sexTets < threeOctectsBits.Length ?
                        threeOctectsBits.Substring(k * sexTets, sexTets) : threeOctectsBits.Substring(k * sexTets);

                    if (sixBits.Length < sexTets)
                        sixBits = sixBits.PadRight(6, '0');

                    int singleInt = Convert.ToInt32(sixBits, 2);

                    base64 += Base64Letters[singleInt];

                    k++;
                }

                j++;
            }

            int remainder = (bits.Length / 8) % 3;
            if (remainder > 0)
                for (var i = 3; i > remainder; i--)
                {
                    base64 += "=";
                }

            return base64;
        }

        public static string ToBase64String(byte[] inArray)
        {
            var bits = string.Empty;
            for (var i = 0; i < inArray.Length; i++)
            {
                bits += Convert.ToString(inArray[i], 2).PadLeft(8, '0');
            }

            // ?????
            return null;
        }

        public static string Base64Encode(string s)
        {
            var bits = string.Empty;
            foreach (var character in s)
            {
                bits += Convert.ToString(character, 2).PadLeft(8, '0');
            }

            string base64 = string.Empty;

            const byte threeOctets = 24;
            var octetsTaken = 0;
            while (octetsTaken < bits.Length)
            {
                var currentOctects = bits.Skip(octetsTaken).Take(threeOctets).ToList();

                const byte sixBits = 6;
                int hextetsTaken = 0;
                while (hextetsTaken < currentOctects.Count())
                {
                    var chunk = currentOctects.Skip(hextetsTaken).Take(sixBits);
                    hextetsTaken += sixBits;

                    var bitString = chunk.Aggregate(string.Empty, (current, currentBit) => current + currentBit);

                    if (bitString.Length < 6)
                    {
                        bitString = bitString.PadRight(6, '0');
                    }
                    var singleInt = Convert.ToInt32(bitString, 2);

                    base64 += Base64Letters[singleInt];
                }

                octetsTaken += threeOctets;
            }

            //// Pad with = for however many octects we have left
            //for (var i = 0; i < (bits.Length % 3); i++)
            //{
            //    base64 += "=";
            //}

            int remainder = (bits.Length / 8) % 3;
            if (remainder > 0)
                for (var i = 3; i > remainder; i--)
                {
                    base64 += "=";
                }

            return base64;
        }

        private static readonly char[] Base64Letters = new[]
                                        {
                                              'A'
                                            , 'B'
                                            , 'C'
                                            , 'D'
                                            , 'E'
                                            , 'F'
                                            , 'G'
                                            , 'H'
                                            , 'I'
                                            , 'J'
                                            , 'K'
                                            , 'L'
                                            , 'M'
                                            , 'N'
                                            , 'O'
                                            , 'P'
                                            , 'Q'
                                            , 'R'
                                            , 'S'
                                            , 'T'
                                            , 'U'
                                            , 'V'
                                            , 'W'
                                            , 'X'
                                            , 'Y'
                                            , 'Z'
                                            , 'a'
                                            , 'b'
                                            , 'c'
                                            , 'd'
                                            , 'e'
                                            , 'f'
                                            , 'g'
                                            , 'h'
                                            , 'i'
                                            , 'j'
                                            , 'k'
                                            , 'l'
                                            , 'm'
                                            , 'n'
                                            , 'o'
                                            , 'p'
                                            , 'q'
                                            , 'r'
                                            , 's'
                                            , 't'
                                            , 'u'
                                            , 'v'
                                            , 'w'
                                            , 'x'
                                            , 'y'
                                            , 'z'
                                            , '0'
                                            , '1'
                                            , '2'
                                            , '3'
                                            , '4'
                                            , '5'
                                            , '6'
                                            , '7'
                                            , '8'
                                            , '9'
                                            , '+'
                                            , '/'
                                        };


    }
}
