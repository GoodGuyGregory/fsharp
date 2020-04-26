## Threads


### Video #1 

**C#'s Suppport for Threads**

in C# Threads can share and exchange information between threads.
Light weight and cheap in the fact that they share pieces of memory, which can be scary. C# allows a program to handle multiple, concurrent operations in an operating system platform.

**Creating a Thread**

```c#
using System;
using System.Threading;
public class one {
    public static void main() {
        // Creates a new two Object:
        new two();
        Console.Write("heavy one");
    }
}

class two {
    // Constructor for the Two object
    public two() {
        Thread newTwo = 
        new Thread(new ThreadStart(run));
        // Calls the Handler run and returns immediately
        // Runs the Start method
        newTwo.Start();
    }

    public void run() {
        Console.Write("light teo start");
    }
}
```

In the above example lines 17 and 31 can run independently. asynchronously. Run completes execution but does not return. and thus there are various running execution possibilities.

DO NOT USE SLEEP AS A CONTROL LOGIC FOR THREADS

**Heavy Weight Threads**

Heavy weight threads require a complete execution of the Method in exectution before another process can execute. in the example of the ball being bounced. the ball's trajectory had to be completed befor another process could be executed.

**Light Weight Threading**

Light-Weight threads could be used to allow for multiple bounces to be executed sumultaneously. the only difference between implementations is that the *this* keyword is used. instances are threaded and not code. In other words the objects extend the thread class's methods and create multiple instances of the objects that can then execute the method and thus run simultantiously or asychronizly

![Java Threading Implementation]()

### C Sharp Threading

Threading in C#, Execution in C# is non-deterministic. In that it cann't be known which thread will be executed first. 

Look at the example below:

```c#
using System;
using System.Threading;
class ST {
    public static void Main() {
        new Simple(1);
        new Simple(2);
        new Simple(3);
        new Simple(4);
    }
}

class Simple {
    int n;
    public Simple(n) {
        this.n = n;
        (new Thread(new ThreadStart(run))).Start();
    }
}

public void run() {
    Thread.Sleep(10);
    Console.WriteLine(n);
    Console.Out.Flush();
}
}
```

try executing this yourself and see that the certainty of the order of threads is certainly uncertain

compile
`mcs simpleThread.cs`

execute
`mono simpleThread.exe`

* An Array Example: The Thread object can even be stored in a data structure.

```csharp
using System;
using System.Threading;
class AT {
 public static void Main() {
 Simple [] sa = new Simple[10];
 for (int i=0; i<10; i++) sa[ i ] = new Simple( i );
 }
}
class Simple {
 int n;
 public Simple(int n) {
 this.n = n;
 (new Thread(new ThreadStart(run))).Start();
 }
 public void run() {
 Thread.Sleep(10);
 Console.WriteLine( n );
 Console.Out.Flush();
 }
}
```

**Greedy Threads**

all the threads compete for the power of exculsive control of the CPU.

**Thread Race Conditions**

Threads Compete for the resources of the CPU and multiple-processors can compete for resources and the execution order is uncertain.

So this raises the question how do we control the thread's execution order?

**Synchronization**

Goals of threads is to achieve execution in parallel or asynchronous. Normal Thread execution should normally be indepenendent of other threads. Controlling the access to an Object is the way that two objects can be accessed together. with *lock*. Lock prevents accessing of the object and causes a wait until the thread that needs to access the object is complete. this is term is called a *monitor * in C#. a monitor allows only on thread to have access to an object at a time. this is implemented with the key work *lock*

**Race Condition Example**

```csharp
using System;
using System.Threading;
class RT {
public static void Main() {
new Racer(1);
new Racer(2);
new Racer(3);
new Racer(4);
}
}
class Racer {
 int n;
 public Racer(int n) {
 this.n = n;
 (new Thread(new ThreadStart(run))).Start();
 }
 public void run() {
 Console.Write("["+n); Console.Out.Flush();
 Thread.Sleep(10);
 Console.WriteLine(n+"]"); Console.Out.Flush();
 }
 } 
```

**Serialized Example**

Lock prevents the use of the Run method 

```csharp
using System; using System.Threading;
 class ST {
 public static void Main() {
 new Racer(1); new Racer(2); new Racer(3);
 }
 }
 class Racer {
 int n;
 static string common = "common";
public Racer(int n) {
this.n = n;
(new Thread(new ThreadStart(run))).Start();
}
public void run() {
lock (common) { // Serialization block
Console.Write("[" + n); Console.Out.Flush();
Thread.Sleep(10);
Console.WriteLine(n + "]"); Console.Out.Flush();
}
}
} 
```

**Monitor Methods**

* *Wait*: suspends thread until Pulse executed by another
thread on the same object
*  *Pulse:* sends signal to one waiting thread Which thread notified is non-deterministic
* *PulseAll:* sends signal to all waiting threads. Only one notified thread can execute any serialized
method on an object at a time. A notified thread continues from point where Wait executed
* Thread enters a dead state when run completes
* The monitor controls access to a serialized object
* No conflict when threads access different objects 

### Common Threading Issues of Bad Code

**Deadlock**

Deadlock occurs when one thread cannot complete. Another Common term is deadly embrase (or Circular wait) where two threads each hold a resource required by the other.

**Starvation**

t1, t2 – Attempt lock on common object.
* t1 claims lock and executes *Wait();*
* t2 claims lock, *Pulse()* not executed.
* t1 never completes. 