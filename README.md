# Pi_Approximator
This is a .NET Windows Form that visually approximates Pi.

I made this just for fun and to brush up on my C# .NET skills. It approximates Pi by creating two regular polygons in relationship to the unit circle. One is circumscribed and one is inscribed. The user can adjust how many sides these polygons have and as the number of sides increases, the more these polygons look like the unit circle. Therefore, the perimeters of the two polygons approach the circumference of the unit circle. The inscribed perimeter will always be less than the circumference and the circumscribed perimeter will always be more. The program averages these two perimeters to find an approximation for the circumference. Then it calculates pi using the formula 
pi = circumference/diameter.
