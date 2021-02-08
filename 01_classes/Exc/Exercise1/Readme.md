Design a class called Stopwatch.The job of this class is to simulate a stopwatch.</br>
It should provide two methods: Start and Stop. We call the start method first, and the stop method next.</br>
Then we ask the stopwatch about the duration between start and stop.</br>
Duration should be a value in TimeSpan.</br>
Display the duration on the console.</br>
We should also be able to use a stopwatch multiple times. So we may start and stop it and then start and stop it again.</br>
Make sure the duration value each time is calculated properly.</br>
We should not be able to start a stopwatch twice in a row (because that may overwrite the initialstart time). So the class should throw an InvalidOperationException if its started twice.