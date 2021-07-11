using System.Collections;
using System.Collections.Generic;
using System;

namespace myClass
{
    class numbers
    {
        public static float minValue(List<float> list)
        {
            int index = 0;
            float lastMinVal1 = 0f;
            float lastMinVal2 = 0f;
            int outputIndex = 0;

            if(list.Count < 3 && list.Count == 2)
                lastMinVal2 = minValue(list[0], list[1]);

            else if(list.Count > 2)
            {
                for(int i = 0; i < list.Count+1; i++)
                {
                    if(index <= list.Count-1)
                    {
                        if(index == 0)
                        {
                            lastMinVal1 = minValue(list[index], list[index+1]);
                        }
                        else if(index > 0)
                        {
                            lastMinVal2 = minValue(lastMinVal1, list[index]);
                            lastMinVal1 = lastMinVal2;
                        }
                    }

                    if(index == 0)
                        index+=2;
                    else
                        index++;
                }
            }
            return lastMinVal2;
        }

        public static float minValue(params float[] list)
        {
            int index = 0;
            float lastMinVal1 = 0f;
            float lastMinVal2 = 0f;
            int outputIndex = 0;

            if(list.Length < 3 && list.Length == 2)
                lastMinVal2 = minValue(list[0], list[1]);

            else if(list.Length > 2)
            {
                for(int i = 0; i < list.Length+1; i++)
                {
                    if(index <= list.Length-1)
                    {
                        if(index == 0)
                        {
                            lastMinVal1 = minValue(list[index], list[index+1]);
                        }
                        else if(index > 0)
                        {
                            lastMinVal2 = minValue(lastMinVal1, list[index]);
                            lastMinVal1 = lastMinVal2;
                        }
                    }

                    if(index == 0)
                        index+=2;
                    else
                        index++;
                }
            }
            return lastMinVal2;
        }

        public static int minValueIndex(List<float> list)
        {
            int outputIndex = 0;
            
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] == minValue(list))
                    outputIndex = i;
            }
            return outputIndex;
        }

        public static int minValueIndex(params float[] list)
        {
            int outputIndex = 0;
            
            for(int i = 0; i < list.Length; i++)
            {
                if(list[i] == minValue(list))
                    outputIndex = i;
            }
            return outputIndex;
        }

        public static float minValue(float float1, float float2)
        {
            return (float1 > float2) ? float2 : float1;
        }

        public static bool hasDecimal(float f)
        {
            return f.ToString().Contains(".");
        }

        public static bool hasDecimal(double d)
        {
            return d.ToString().Contains(".");
        }
    }
    class words
    {
    }
    class SaveLoadSystem
    {
        public static void SaveLine(string index, params type values)
        {
            
        }
    }
}