# myPOS-SDK-dotNET

This repository provides .Net C# SDK, which enables to integrate your Application with myPOS Card terminals, processed by its platform, to accept card payments (including but not limited to VISA, Mastercard, UnionPay International, JCB, Bancontact). myPOS SDK .Net communicates transparently to the card terminal(s) via USB cable. To process checkout SDK provides management of the terminal to complete all the steps for transaction processing, return or refund, and communicates to the application transaction status, card masked PAN.

No sensitive card data is ever passed through to or stored on the merchant&#39;s application. All data is encrypted by the card terminal, which has been fully certified to the highest industry standards (PCI, EMV I &amp; II, Visa, MasterCard &amp; Amex).

### Prerequisites

1. Merchant account on [www.myPOS.eu](https://www.mypos.eu/) (or received a test account).
2. Received myPOS terminal
3. Requested Access   [Developers myPOS](http://developers.mypos.eu) site.
4. .Net Framework version 4.5.2 

### Table of Contents

* [Integration](#integration)

  * [Dependency](#dependency)
  
  * [Initialization](#initialization)

  * [Connect to terminal](#connect-to-terminal)
  
* [Make transactions](#make-transactions)

  * [Handle response result](#handle-response-result)
  
  * [Make a payment](#make-a-payment)
  
  * [Make a refund](#make-a-refund)
  
  * [Reprint last receipt](#reprint-last-receipt)

  * [Custom receipt print](#custom-receipt-print)

* [Terminal mangement](#terminal-management)

  * [Activate terminal](#activate-terminal)
  
  * [Update terminal software](#update-terminal-software)
  
  * [Deactivate terminal](#deactivate-terminal)
  
  
# Integration

As example of integration, please use the sample app provided in this repository as a reference.

## Dependency

In order to use myPOS Terminal .Net SDK, you need to have installed .Net Framework version 4.5.2 or above.

1.	In Solution Explorer in Visual Studio, select the project.
2.	On the Project menu, click Add Reference. The Add Reference dialog box opens.
3.	Browse to the downloaded ‘myPOSTerminal.dll’ and click the Select button.
4.	After confirming with OK, the selected reference ‘myPOS Terminal’ will appear under the References node of the project

## Initialization

In order to use myPOS Terminal .Net SDK methods, you need to create an object of myPOSTerminal class:

```C#
using myPOS;
myPOSTerminal terminal = new myPOSTerminal();
```

You can set terminal language and receipt configuration mode here. If those are not set anywhere in the application, the POS device will use its default settings:

```C#
terminal.SetReceiptMode((ReceiptMode)cmbReceiptMode.SelectedItem);
terminal.SetLanguage(Language.English);
```

## Connect to terminal

Each time the POS device is plugged, you have to specify the COM Port is uses and initiate a new connection:

```C#
terminal.Initialize((string)"COM3"); // This COM number is used as an example
```

# Make transactions

## Handle response result

There is an event that is raised when a response is received from the POS device on a particular request. You should subscribe to the event to get the response result and any response data that is received.

1.	Define an event handler method 

```C#
       protected void ProcessResult(ProcessingResult r)
       {
	       // handle the response here
            if (r.TranData != null)
            {
		          // transaction response
            }
 	}
       
```

2.	Attach your event handler to the event:

```C#
    public Form1()
    {
         InitializeComponent();
          
         terminal.ProcessingFinished += ProcessResult;
    }

```

## Make a payment

Once initialization and connection to terminal is completed, you can start using the myPOS Terminal .Net SDK to accept card payments.

```C#
RequestResult r = terminal.Purchase(Amount, cur, txtReference.Text);
```

Transaction reference is optional parameter and can be empty or NULL.

## Make a Refund

You can initiate refund transaction to the customer’s card account with the specified amount.

```C#
RequestResult r = terminal.Refund(Amount, cur, txtReference.Text);
```
Transaction reference is optional parameter and can be empty or NULL.

## Reprint last receipt

With this method the host application could request reprint of the last transaction slip.

```C#
RequestResult r = terminal.ReprintReceipt();
```

## Custom receipt print

You can print receipt with your custom data using the following delimiters:

\\ - symbol \
\n – new line
\L – prints logo
\l – left alignment
\c - center alignment
\r - right alignment
\W – double width
\w – normal width
\H – double height
\h – normal height

```C#
terminal.PrintExternal(txtPrintData.Text);
```

# Terminal management

## Activate

Before using terminal for a first time, the myPOS Terminal SDK has to initiate Terminal activation, which will setup terminal for processing transaction, setting up Terminal ID, Merchant ID etc.

```C#
RequestResult r = terminal.Activate();
```

## Update terminal software

Each time terminal processing transactEach time terminal is processing transaction, the processor host checks for existing pending updates and inform terminal if any. With this method, the update procedure is started and the terminal is going in the update mode. 

```C#
RequestResult r = terminal.Update();
```

## Deactivate terminal

```C#
RequestResult r = terminal.Deactivate();
```
