using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute(Animator anim, bool forward);
}

public class MoveForward : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        if (forward)
        {
            anim.SetTrigger("isWalking");
        }
        else
        {
            anim.SetTrigger("isWalkingR");
        }
    }
}

public class Jump : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        if (forward)
        {
            anim.SetTrigger("isJumping");
        }
        else
        {
            anim.SetTrigger("isJumpingR");
        }
    }
}

public class Kick : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        if (forward)
        {
            anim.SetTrigger("isKicking");
        }
        else
        {
            anim.SetTrigger("isKickingR");
        }
    }
}

public class Punch : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        if (forward)
        {
            anim.SetTrigger("isPunching");
        }
        else
        {
            anim.SetTrigger("isPunchingR");
        }
    }
}

public class DoNothing : Command
{
    public override void Execute(Animator anim, bool forward)
    {

    }
}
