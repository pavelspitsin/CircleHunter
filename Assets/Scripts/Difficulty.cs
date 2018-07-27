using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Difficulty
{
    public float FrequencyAddCircle { get; set; }
    public float DeadLineExpiredTime { get; set; }
    public float CircleLifeTime { get; set; }
    public float ProbabilityAddSecondCircle { get; set; }
    public float ProbabilityAddRedCircle { get; set; }
}


public static class Difficulties
{

    public static Difficulty Easy { get; set; }
    public static Difficulty Normal { get; set; }
    public static Difficulty Hard { get; set; }
    public static Difficulty VeryHard { get; set; }

    static Difficulties()
    {
        Easy = new Difficulty()
        {
            FrequencyAddCircle = 1.2f,
            DeadLineExpiredTime = 2f,
            CircleLifeTime = 2.5f,
            ProbabilityAddRedCircle = 0.2f,
            ProbabilityAddSecondCircle = 0
        };

        Normal = new Difficulty()
        {
            FrequencyAddCircle = 0.9f,
            DeadLineExpiredTime = 2f,
            CircleLifeTime = 1.5f,
            ProbabilityAddRedCircle = 0.3f,
            ProbabilityAddSecondCircle = 0.2f
        };

        Hard = new Difficulty()
        {
            FrequencyAddCircle = 0.7f,
            DeadLineExpiredTime = 1.8f,
            CircleLifeTime = 1.0f,
            ProbabilityAddRedCircle = 0.5f,
            ProbabilityAddSecondCircle = 0.4f
        };

        VeryHard = new Difficulty()
        {
            FrequencyAddCircle = 0.6f,
            DeadLineExpiredTime = 1.6f,
            CircleLifeTime = 0.8f,
            ProbabilityAddRedCircle = 0.7f,
            ProbabilityAddSecondCircle = 0.6f
        };

    }
}