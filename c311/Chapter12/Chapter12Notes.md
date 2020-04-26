## Memory Allocation 

**Passing By Reference**

Passing by references is when a function takes the memory address of a variable and not the contents of the dereferenced instances

Examine the Following C++ Function

```c++
void SUB(int &K, float &X) {
K = 1;
X = 20;
}
void main(void) {
float A[2];
int I;
I = 0;
A[0] = 10;
A[1] = 11;
SUB(I, A[I]);
cout << A[0] << " " << A[1] << "\n";
}
```
returns A[0] = 20 and A[1] = 10

**Key to ActivationM Records**

* M – Memory, a linear array M[0],...,M[n].
* PAR – Address of caller’s parameters, PAR[1],...PAR[n].
* IP – Caller’s return address.
* TMP – Temporary storage of Caller’s registers.
* DL – Dynamic Link to Caller’s Activation Record.
* AR(S) – The Activation Record address of function S.

**Passing by Value**

