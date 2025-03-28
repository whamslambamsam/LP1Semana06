using System;

namespace MyGame
{
    public class Enemy
    {
        public Enemy(string name)
        {
            this name = name; // name oculta this.name
            int health = 100;
            int shield = 0;
        }

        public string GetName(string name)
        {
            return name;
        }
        
        public void TakeDamage(float damage)
        {
            // A variável shield é subtraida pelo valor da variável damage
            shield -= damage;

            // Se a variável shield for menor que zero, então:
            if (shield < 0)
            {
                // Cria uma variável que guarda o valor negativo do shield
                float DamageStillToInflict = -shield;
                // Define shield como 0
                shield = 0;
                // Subtrai o valor da variável health pela variável 
                // DamageStillToInflict
                health -= DamageStillToInflict;
                // Se a variável health for menor que 0, será definida de volta
                // para 0.
                if (health < 0) health = 0;
            }
        }
    }
}