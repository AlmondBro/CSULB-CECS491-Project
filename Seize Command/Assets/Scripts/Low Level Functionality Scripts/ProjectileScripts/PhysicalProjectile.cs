using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* PhysicalProjectile class
 * So basically the point of this class is to handle things that Physical Projectiles do: Cannon, Shotgun, etc.
 * In this case it would be setting the velocity speed and making sure we can reference the damage when it hits another object
 * @AUSTIN: When you make your health manager you can find the damage of the projectile by calling the property
 *      below like this: proj.ProjectileDamage.  where "proj" is an object of this class
 * TO DO: Make a base class for Projectile so that this class and other classes like Beam can extend from it
 *      I have not done this yet because I'm unsure what would go in the base class
 */

//[RequireComponent] is an attribute. Essentially when i drop this class onto an object in the inspector, 
//  it will make sure that the object has a Rigidbody2D component attached

//[SerializeField] is another attribute.  In Unity the only variables that are Serialized in the inspector are public variables.
//  So if we wanted to set the values of projectileSpeed and projectileDamage in the inspector they would have to be public.
//  However, if we don't want the variables to be public and we still want to be able to set them in the inspector we can use this attribute.

//ProjectileDamage is a property.  Think of it this way:  It's a fancy Get/Set.  The one I have created below allows all classes to
//  get the value of projectileDamage but only this class and classes that inherit from it can change its value

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicalProjectile: MonoBehaviour
{
    [SerializeField] float projectileSpeed;
    [SerializeField] float projectileDamage;

    Rigidbody2D rb;

    public float ProjectileDamage
    {
        get
        {
            return projectileDamage;
        }
        protected set
        {
            projectileDamage = value;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetProjectileSpeed();
    }

    //Multiply the current velocity by the speed
    void SetProjectileSpeed()
    {
        rb.velocity = transform.up * projectileSpeed;
    }
}
