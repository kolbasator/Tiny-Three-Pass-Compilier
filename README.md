# Tiny-Three-Pass-Compilier 

## Description

  Tiny compiler . You can make some simple function and calculate it with args.
  Supported +,-,/,*,^,cos,sin,tan,ctn,log,ex operators.
  Also can parse expression without spaces.

## Code snippet 

   ```
   
  Console.WriteLine( Simulator.Calculate("[ x y z ] ( 2*3*x + 5*y - 3*z ) / (1 + 3 + 2*2) + 1.76", new double[3] { 4, 8, 16 }));   // output :3.76
   
  Console.WriteLine( Simulator.Calculate("[ x ] (x+5.1)", new double[1] { 15 }));   // output :20.1
   
  Console.WriteLine( Simulator.Calculate("[ x ] x + 10", new double[1] { 1.56 }));   // output :1.56
   
  Console.WriteLine( Simulator.Calculate("[ x y l ] x * y + l", new double[3] { 100, 100 , 7.98 }));   // output :10007.98 
   
  Console.WriteLine( Simulator.Calculate("[a, b, c, d] ( 3 *a + 2*b + 5*c+ 7*d+100)", new double[4] { 4, 8,6,18 }));   // output :284 
  
  Console.WriteLine( Simulator.Calculate("[ x ] x + cos ( 1 / 2 ) + sin ( 1 / 2 )",new double[1] { 1 }));   // output :2.10028204919844 
  
  Console.WriteLine( Simulator.Calculate("[ c ] ctn ( c ) + c", new double[1] { 5 }));   // output :4.704187084467255
  
  Console.WriteLine( Simulator.Calculate("[ z ] tan ( z ) + z", new double[1] { 5 }));   // output :1.6194849937534141
  
  Console.WriteLine( Simulator.Calculate("[ v ] ex ( v ) * v + 3", new double[1] { 6 }));   // output :2423.57276096
  
  Console.WriteLine( Simulator.Calculate("[ c ] log ( 5 ) + c", new double[1] { 10 }));   // output :10.47588499532711 
  
   ```
