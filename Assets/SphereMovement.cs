using System;

using UnityEngine;
//namespace MathClassCS;

public class SphereMovement : MonoBehaviour
{  public double v0,vx, vxp, RO0 = 1.15,ro,A,r,cd=0.45,vy,vyp,g,gp,GM=Math.Pow(10.0,-11.0)*6.67*5.97*Math.Pow(10,24),R=6371000,x,xp,y,yp,beta,v,alfa,k;
    public bool ruszaj=false;
    //public Transform player;
    // public Vector3 offset;
   // public float a = 0.9f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (ruszaj)
        {
           // Debug.Log("Ruszono");
            //transform.position = new Vector3( 4,  1, transform.position.z);
            //ustawienie pozycji kuli
           // if(y>-1)
            transform.position = new Vector3(Convert.ToSingle(x), Convert.ToSingle(y), transform.position.z);
            // transform.position = new Vector3((transform.position.x) + 0.1f, (transform.position.y) + 0.1f, transform.position.z);
            //przypisanie starym wartościom aktualnych
            vxp = vx;
            vyp = vy;
            gp = g;
            A = Math.PI * Math.Pow(r, 2);
            xp = x;
            yp = y;


            //zmiana wartości
            ro = RO0 * Math.Pow(Math.E, (-0.1 * yp));
/*            k = 0.5 * ro * A * cd;
            vx = vxp - k * Math.Pow(vxp, 2) * Time.fixedDeltaTime;
            vy = vyp - gp * Time.fixedDeltaTime - k * Math.Pow(vyp, 2) * Time.fixedDeltaTime;
            x = xp + vx * Time.fixedDeltaTime - 0.5 * k * Math.Pow(vx, 2) * Math.Pow(Time.fixedDeltaTime, 2);
            y = yp + vy * Time.fixedDeltaTime - 0.5 * gp * Math.Pow(Time.fixedDeltaTime, 2) - 0.5 * k * Math.Pow(vy, 2) * Math.Pow(Time.fixedDeltaTime, 2);
*/

            k = 6 * Math.PI * 18 * Math.Pow(10, -6) * r;
            vx = vxp - k * vxp * Time.fixedDeltaTime;
            vy = vyp - gp * Time.fixedDeltaTime - k * vyp * Time.fixedDeltaTime;
            x = xp + vx * Time.fixedDeltaTime - 0.5 * k * vx * Math.Pow(Time.fixedDeltaTime, 2);
            y = yp + vy * Time.fixedDeltaTime - 0.5 * gp * Math.Pow(Time.fixedDeltaTime, 2) - 0.5 * k * vy * Math.Pow(Time.fixedDeltaTime, 2);
            g = GM / (Math.Pow((R + y),2));
            v = Math.Sqrt(vx * vx + vy * vy);


            //JESZCZE KĄT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double tangens,radians,gamma;
           
                tangens = vy / vx;
                radians = Math.Atan(tangens);
                gamma = radians * (180 / Math.PI);
            if (gamma < alfa)
            { beta = alfa - gamma; }
            else
            { beta = alfa + gamma; }
            }













//sprawdzenie, czy y<0. jeśli tak, to ruszaj=false
if (y < 0) { ruszaj = false;
    y = 0;
    v = 0;
    transform.position = new Vector3(Convert.ToSingle(x), Convert.ToSingle(y), transform.position.z);
}















}
//else do ruszaj, resetowanie wartości x i y (ale bez wektora)


// transform.position= player.position+offset;
}




