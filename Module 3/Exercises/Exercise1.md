### Exercise: Analyzing Unmanaged Memory Leak

#### Objective:
Get familiar with identifying and analyzing unmanaged memory leaks in a .NET application using various tools.

#### Steps:

1. **Open Visual Studio**
   - Ensure that Visual Studio is installed and open on your machine.

2. **Set the Startup Project**
   - Make sure the startup project is set to `MemoryIssue2`.

3. **Start Performance Profiling**
   - Go to `Debug` -> `Performance Profiler...`.
   - Check the checkbox next to `.NET Counters`.
   - Press the `Start` button below to begin profiling.

4. **Monitor Performance with PerfMon**
   - While the application is running, open `Performance Monitor (PerfMon)`.
   - Add the following counters:
     - `Process -> Private Bytes`
     - `Process -> Virtual Bytes`
     - `Process -> Working Set - Private`
   - Ensure you select the correct process (`MemoryIssue2`).

5. **Observe Private Bytes Growth**
   - Monitor the `Private Bytes` counter and observe its growth over time.

6. **Analyze Memory with VMMap**
   - Open `VMMap`.
   - Choose `MemoryIssue2.exe`.
   - Note the heap size and how much of it is committed and private bytes.

7. **Run dotnet-counters monitor**:
   - Find the process's ID by running the following command:
     ```sh
     dotnet-counters ps
     ```
   - Start monitoring performance counters by running the following command:
     ```sh
     dotnet-counters monitor --process-id <PID>  --counters System.Runtime --refresh-interval 1
     ```
   - Replace `<PID>` with the process ID of your application.
   - Look at dotnet.gc.heap.total_allocated (By). Is it as large as you expected?

7. **Stop the Profiling Session**
   - Return to Visual Studio.
   - Stop the profiling session and wait for the results to load.

8. **Analyze the Results**
   - Answer the following questions based on the profiling results:
     - How many garbage collections (GCs) occurred? Which generations?
     - How many GC committed bytes were there?
     - What was the maximum heap size?
     - Note the difference in the numbers from the Private Bytes you recorded earlier