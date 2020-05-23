# Pi_Approximator
This is a .NET Windows Form that visually approximates π.

## Overview
I made this just for fun and to brush up on my C# .NET skills. It approximates π by creating two regular polygons in relationship to the unit circle. One is circumscribed and one is inscribed. This method was inspired by [Archimedes' Method.](https://en.wikipedia.org/wiki/Pi#Polygon_approximation_era) The user can adjust how many sides these polygons have and as the number of sides increases, the more these polygons look like the unit circle. Therefore, the perimeters of the two polygons approach the circumference of the unit circle. The inscribed perimeter will always be less than the circumference and the circumscribed perimeter will always be more. The program averages these two perimeters to find an approximation for the circumference. Then it calculates π using the formula 
π = circumference/diameter.

## Finding the Points of the Inscribed Polygon
#### Initial Idea
To draw an inscribed n-gon we need to find n evenly spaced points that lie on the unit circle. My first idea was to take the number of degrees in a circle, divide it by n, and then the x value would be the cosine and the y value would be the sine. However, the C# implementation of sin and cosine use radians as the argument. So I either have to use radians from the beginning or convert degrees to radians. Either one requires knowing the value of π. Because using π to calculate π feels silly, I came up with another solution. 

#### Solution
I used something called the [Roots of Unity](https://en.wikipedia.org/wiki/Root_of_unity) to find the points on the unit circle. The nth Roots of Unity are complex numbers x, that solve the equation x<sup>n</sup>=1. These complex solutions lie on the unit circle in the complex plane. Essentially, to find the points of an inscribed n-gon, you only have to solve the polynomial x<sup>n</sup> - 1 = 0. Rather than build a polynomial root finder myself, I used the [Math.NET](https://numerics.mathdotnet.com/) package.

## Finding the Points of the Circumscribed Polygon
I used the points of the inscribed polygon to find the circumscribed polygon's points. For two adjacent points of the inscribed polygon, I could find a point on the circumscribed polygon between them by finding the intersection of two lines tangent to the circle at the inscribed polygon's points.
