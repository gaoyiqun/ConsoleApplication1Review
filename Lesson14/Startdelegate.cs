using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson14
{
    public delegate void Startdelegate();

    class Eventdemo : Form
    {
        public event Startdelegate StartEvent;

        public Eventdemo()
        {
            Button clickMe = new Button();

            clickMe.Parent = this;
            clickMe.Text = "Click Me";
            clickMe.Location = new Point((ClientSize.Width - clickMe.Width)/2, 
                                         (ClientSize.Height - clickMe.Height)/2);

            //an EventHandler delegate is assigned
            //to the button's Click event

            clickMe.Click += new EventHandler(OnClickMeClicked);

            //we have a delegate of type Startdelegate, which the event was declared to accept,
            //hooked up to the StartEvent event. 
            //The += syntax registers a delegate with an event. 
            //To unregister with an event, use the -= with the same syntax.
            StartEvent += new Startdelegate(OnStartEvent);

            StartEvent();
        }

        private void OnStartEvent()
        {
            MessageBox.Show("I Just Started!");
        }

        private void OnClickMeClicked(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked My Button!");
        }
    }
   
}
