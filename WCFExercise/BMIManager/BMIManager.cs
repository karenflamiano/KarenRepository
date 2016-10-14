using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService;
using WCFExercise.ServiceReference2;
using WebService.Request;
using WebService.Response;

namespace WCFExercise
{
    public class BMIManager
    {
        Service1Client service = new Service1Client();

        public HeightResponse getHeight(double inputHeight, string inputType)
        {
            GetHeightRequest heightRequest = new GetHeightRequest()
            {
                height = inputHeight,
                type = inputType
            };
            HeightResponse response = new HeightResponse();
            response = service.GetHeight(heightRequest);
            return response;
        }

        public WeightResponse getWeight(double inputWeight, string inputType)
        {
            GetWeightRequest weightRequest = new GetWeightRequest()
            {
                weight = inputWeight,
                type = inputType
            };
            WeightResponse response = new WeightResponse();

            response = service.GetWeight(weightRequest);
            return response;
        }

        public CalculateBMIResponse getBMI(double inputHeight, double inputWeight)
        {
            BMIConversionRequest bmiRequest = new BMIConversionRequest()
            {
                height = inputHeight,
                weight = inputWeight
            };
            CalculateBMIResponse response = new CalculateBMIResponse();
            response = service.CalculateBMI(bmiRequest);
            return response;
        }

    }

}