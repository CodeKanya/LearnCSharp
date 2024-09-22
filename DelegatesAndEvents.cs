using Dumpify;
/*
How It Works:
Delegate AlertHandler: Defines the method signature (taking a string).
Event OnHeartRateHigh: Raised when the heart rate exceeds 100.
Doctor subscribes to the event and gets alerted when the event is triggered.
*/
public class DelegatesAndEvents{

    // Step 1 : Define a delegate (method signature for the event)  
    public delegate void  AlertHandler (string message);

    // Publisher Class
    public class HeartRateMonitor{
        // Declare an event
        public event AlertHandler OnHeartRateHigh = delegate { };

        public void CheckHeartRate(int heartRate){
            // If heart rate exceeds 100, trigger the event
            if(heartRate>100){
                OnHeartRateHigh?.Invoke($"Heart rate too high {heartRate}");
            }
            else{
                Console.WriteLine("Do nothing");
            }
        }
    }

    // Subscriber class
    public class Doctor{
        public void ReceiveAlert(string message) => Console.WriteLine($"Doctor Alert{message}");    
    }

    public void LearnDelegatesAndEvents(){
        // Publisher
        HeartRateMonitor heartRateMonitor = new HeartRateMonitor();

        //Subscriber
        Doctor doctor = new Doctor();

        // Subscribe to the event
        heartRateMonitor.OnHeartRateHigh += doctor.ReceiveAlert;    

        //Trigger the event if heart rate is high
        heartRateMonitor.CheckHeartRate(80);
        heartRateMonitor.CheckHeartRate(101);
    }
} 