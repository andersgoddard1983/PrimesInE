From "Are you smart enough to work at Google?" by William Poundstone:

In July 2004, two enigmatic billboards went up on opposite sides of the country. One was in Harvard Square; the other, off Highway 101 in 
Silicon Valley. Each billboard was stark black text on a white background, reading:

{first 10-digit prime found in consecutive digits of e}.com

There may have been simpler ways to solve this than in C# as a Windows Form but, given that's what I was teaching myself when I read the passage, I decided to try solving it in C#. Actually, I solved it as a console application first but I wanted a more elegant way of seeing the solution than by setting a breakpoint, so I did it as a form - I haven't committed that solution because I broadly use the same logic here, albeit without the Console.WriteLine outputs.

How I solved it:

1. Given that I didn't know when the prime would arrive, and was conscious of the number of decimal places I might be able to have with a C# decimal datatype, I decided to put as many decimal places as I could find in a text file. I found e to 2 million decimal places at https://apod.nasa.gov/htmltest/gifcity/e.2mil.

2. I used a while loop to loop through the whole text file line by line and a for loop to shift the 10-digit number I was testing in each iteration. (I have actually removed two of the conditions from the for loop in this commit because they're not needed - the remainder variable is never equal to an empty string and i never reaches the length of the line. Those conditions are a legacy from how I thrashed out the for loop.)

3. I left the 10-digit numbers as strings as long as I could, so as not to hit any issues with their size. I used int64, so I needn't have worried, but equally leaving them as strings made it easy to concatenate the remaining decimal places to the next line of decimal places at the start of each new for loop.

4. Quite a simple visual but I had the click of the button change the text in the Window Form to the prime number returned.

So the website Google were advertising in 2004 was www.7427466391.com. It won't surprise anyone to hear that the website isn't up anymore!

