/*
    Synchronous - Operations are Sequential , Blocking Nature
    Asynchronous - Operations are concurrent OR parallel, Non-blocking nature 
*/
/*
Threads: Smallest unit of execution in a process. 
Tasks: Represents an asynchronous operation,designed to simplify the work of managing threads. 
Multithreading: Running multiple workers (threads) to do things simultaneously.
Asynchronous: Efficient waiting; let your program keep working while waiting for 
            slow tasks (uses async/await).
*/
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class ParallelAndAsynchronous{

    public void LearnParallelAndAsynchronous(){
        Threading threading = new Threading();
        //threading.LearnThreading();
        Asynchronous asynchronous = new Asynchronous();
        asynchronous.LearnAsynchronous();
    }

    public class Asynchronous{

        public async void LearnAsynchronous (){
            Console.WriteLine("Fetching user data...");
            var user = await FetchUserDataAsync("https://jsonplaceholder.typicode.com/users/1");
            Console.WriteLine($"User Name: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine("Data fetched successfully.");
        }
        static async Task<User> FetchUserDataAsync(string url)
            {
                using (HttpClient client = new HttpClient())
                {
                    // Asynchronously send a GET request
                    var response = await client.GetStringAsync(url);
                    // Deserialize the JSON response into a User object
                    var user = JsonConvert.DeserializeObject<User>(response);
                    return user;
                }
            }
    }
    public class Threading{
        static void Count(object threadNumber)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread {threadNumber}: {i}");
                Thread.Sleep(100); // Simulate work
            }
        }

        public void LearnThreading(){
            Thread thread1 = new Thread(Count);
            Thread thread2 = new Thread(Count);

            thread1.Start(1); // Start thread with argument 1
            thread2.Start(2); // Start thread with argument 2

            thread1.Join(); // Wait for thread1 to complete
            thread2.Join(); // Wait for thread2 to complete

            Console.WriteLine("All threads complete.");
            } 
    }

    
}

// Define the User class to match the structure of the API response
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}