internal class Day2
{
    public void Whole()
    {
        string data = "data/day2.txt";
        int score = this.Part1(data);
        Console.WriteLine(String.Format("Day 2 Part 1 {0}", score.ToString()));
        int secondscore = this.Part2(data);
        Console.WriteLine(String.Format("Day 2 Part 2 {0}", secondscore.ToString()));
    }

    internal int Part1(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        int total = 0;

        foreach (string line in lines)
        {
            string opponent = line.Substring(0, 1);
            string me = line.Substring(2);

            Hand opponentHand = this.OppoentHand(opponent);
            Hand myHand = this.MyHand(me);

            int score = this.Score(myHand, opponentHand);

            total += score;

        }

        return total;
    }

    internal int Part2(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        int total = 0;

        foreach (string line in lines)
        {
            string opponent = line.Substring(0, 1);
            string me = line.Substring(2);

            Hand opponentHand = this.OppoentHand(opponent);
            Hand myHand = this.MyNewHand(me, opponentHand);

            int score = this.Score(myHand, opponentHand);

            total += score;

        }

        return total;
    }

    private Hand OppoentHand(string hand)
    {
        if (hand == "A")
        {
            return Hand.Rock;
        }
        else if (hand == "B")
        {
            return Hand.Paper;
        }
        else if (hand == "C")
        {
            return Hand.Scissors;
        }
        else
        {
            throw new Exception(String.Format("Unknown String input {0}", hand));
        }
    }

    private Hand MyNewHand(string hand, Hand opponent)
    {
        Outcome outcome = this.MyHandToOutcome(hand);

        if (outcome == Outcome.Win)
        {
            switch (opponent)
            {
                case Hand.Rock:
                    return Hand.Paper;
                case Hand.Paper:
                    return Hand.Scissors;
                case Hand.Scissors:
                    return Hand.Rock;
            }
        }
        else if (outcome == Outcome.Draw)
        {
            return opponent;
        }
        else if (outcome == Outcome.Lose)
        {
            switch (opponent)
            {
                case Hand.Rock:
                    return Hand.Scissors;
                case Hand.Paper:
                    return Hand.Rock;
                case Hand.Scissors:
                    return Hand.Paper;
            }
        }


        throw new Exception("Unreachable Code");
    }

    private Outcome MyHandToOutcome(string hand)
    {
        if (hand == "X")
        {
            return Outcome.Lose;
        }
        else if (hand == "Y")
        {
            return Outcome.Draw;
        }
        else if (hand == "Z")
        {
            return Outcome.Win;
        }
        else
        {
            throw new Exception("Unreachable code");
        }
    }

    private Hand MyHand(string hand)
    {
        if (hand == "Y")
        {
            return Hand.Paper;
        }
        else if (hand == "X")
        {
            return Hand.Rock;
        }
        else if (hand == "Z")
        {
            return Hand.Scissors;
        }
        else
        {
            throw new Exception(String.Format("Unknown String input {0}", hand));
        }
    }

    private int Score(Hand myHand, Hand opponentHand)
    {
        Outcome outcome = this.WinLose(myHand, opponentHand);

        int outcomeScore = this.OutcomeToInt(outcome);
        int handScore = this.HandToInt(myHand);

        return outcomeScore + handScore;
    }

    private Outcome WinLose(Hand myHand, Hand opponentHand)
    {

        if (myHand == opponentHand)
        {
            return Outcome.Draw;
        }

        if (myHand == Hand.Rock)
        {
            if (opponentHand == Hand.Paper)
            {
                return Outcome.Lose;
            }
            else
            {
                return Outcome.Win;
            }
        }

        if (myHand == Hand.Paper)
        {
            if (opponentHand == Hand.Rock)
            {
                return Outcome.Win;
            }
            else
            {
                return Outcome.Lose;
            }
        }

        if (myHand == Hand.Scissors)
        {
            if (opponentHand == Hand.Rock)
            {
                return Outcome.Lose;
            }
            else
            {
                return Outcome.Win;
            }
        }

        throw new Exception("Unreachable code");
    }

    private int OutcomeToInt(Outcome outcome)
    {
        switch (outcome)
        {
            case Outcome.Win:
                return 6;
            case Outcome.Draw:
                return 3;
            case Outcome.Lose:
                return 0;
        }

        throw new Exception("Unreachable Code");
    }

    private int HandToInt(Hand hand)
    {
        switch (hand)
        {
            case Hand.Rock:
                return 1;
            case Hand.Paper:
                return 2;
            case Hand.Scissors:
                return 3;
        }

        throw new Exception("Unreachable Code");
    }
}

enum Outcome
{
    Win,
    Draw,
    Lose
}

enum Hand
{
    Rock,
    Paper,
    Scissors
}