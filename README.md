# ATM

The project was developed using .NET EntityFramework 6.4.4. , project has been developed in accordance with layered architecture. Attention was paid to SOLID principles and object-oriented programming. The project was created as code-first and migrations are applied. Fluent validation was used for validation processes. Ninject technology was used as IOC container. MD5 algorithm was used for hash operations. 


Database Diagrams;
![AtmDb](https://user-images.githubusercontent.com/128610192/231908931-e634e34f-f8b6-4af4-b22c-a9ca50edf1be.JPG)





The screen that welcomes you when the application runs ;
![WelcomeScreen](https://user-images.githubusercontent.com/128610192/231907132-41d8d1d2-63f8-4239-93c7-4a8fc9e38f43.JPG)

When we click on the I want to be I want to be customer button, We add information requested from us. 
Validation (Fluent Validation) and hashing (MD5) takes place for this informations;

![AddCustomer](https://user-images.githubusercontent.com/128610192/231907710-06f0bf2c-5f41-43bf-8310-6270e78d805a.JPG)



When we click on the customer button, Query is made whether the customer number and password we entered are registered in our database;

![IdentityScreen](https://user-images.githubusercontent.com/128610192/231907832-c7fe1580-f448-4f3b-bf32-7ec848916f17.JPG)



If query return true, We can see this screen ;

![CustomerFirstScreen](https://user-images.githubusercontent.com/128610192/231907960-baa5197b-7020-41b8-af96-cd0fb6aeab01.JPG)



When we click on the Withdray / Deposit Money button;

![WithdrawAndDepositMoney](https://user-images.githubusercontent.com/128610192/231908059-a6edf310-50cc-41ed-a854-846d28ac9633.JPG)



When we click on the Investment button;
After writing the amount to be deposited, click the investment button, insertion takes place for logged in user.

![Investment](https://user-images.githubusercontent.com/128610192/231908151-4366df37-1b3f-4e1e-a6d8-38717ed2319e.JPG)



When we click on the Withdraw Money button;
After writing the amount to be drawn, click the draw button, draw takes place for logged in user.

![WithdrawMoney](https://user-images.githubusercontent.com/128610192/231908201-d76ae741-9e1c-4aea-ae1e-7479394d815d.JPG)



When we click on the Balance Information button in Process screen;

![BalanceInformation](https://user-images.githubusercontent.com/128610192/231908238-6e884ead-efb0-4230-85a9-abcefe93fac5.JPG)



When we click on the Money Transfer button in Process screen;

![MoneyTransfer](https://user-images.githubusercontent.com/128610192/231908286-4eecfe91-8d9f-4d38-895f-31109462480f.JPG)



When we click on the Not Our Customer Transfer button; 
We will send the Money for those who are not our customers and amount will be deducted from our account.

![NotOurCustomerMoneyTrasfer](https://user-images.githubusercontent.com/128610192/231908361-60a4910a-932a-466a-8de1-3b5217799774.JPG)



When we click on the Our Customer Transfer button; 
We will send the Money for those who are our customers and amount will be deducted from our account. Amount will be added to our customer.

![OurCustomerMoneyTransfer](https://user-images.githubusercontent.com/128610192/231908406-2e9a92d2-e4d4-4c4b-81e2-163f84904253.JPG)



When we click on the Payment Transaction button in Process screen;

![PaymentTransaction](https://user-images.githubusercontent.com/128610192/231908509-d5425825-3d10-448d-8ec0-dd3896764888.JPG)



When we click on the Bills button;
The invoice type to be paid is selected from the combobox. 

![Bills](https://user-images.githubusercontent.com/128610192/231908542-ad174a7a-0b16-4f24-918e-d1f3878c48bf.JPG)



If the customer has debts for this invoice type, we will see this screen;
And payment will be processed

![PayBill](https://user-images.githubusercontent.com/128610192/231908622-2b3c458c-5f50-4bcf-90f4-4003e806d186.JPG)



When we click on the Credit Card Transaction button in Process screen;

![CreditCardTransaction](https://user-images.githubusercontent.com/128610192/231908656-5b596802-1047-48c1-873f-6217a9a3a236.JPG)



When we click on the Credit Card Application button;
The credit card application happen for the amount selected from the combobox.

![CreditCardApplication](https://user-images.githubusercontent.com/128610192/231908685-310a55c8-ecec-4a11-a36d-b65345c027a3.JPG)



When we click on the Credit Card Debt button;
We see information about the credit card. After selecting the payment type from the radio button, we click the Pay button, the amount paid is from the money in our account and deducted from credit card debt

![CreditCardDebt](https://user-images.githubusercontent.com/128610192/231908748-8de2b038-aec3-45e9-9a85-a472afbeda1f.JPG)



When we click on the non-customer button after the program run;

![NonCustomerFirstScreen](https://user-images.githubusercontent.com/128610192/231908791-b48855de-58f7-4c06-9eec-85684c362ef9.JPG)



When we click on the Credit Card Debt button;
Credit card debt can be paid by entering the card number

![NonCustomerCreditCardDebt](https://user-images.githubusercontent.com/128610192/231908814-921d5276-fc13-481d-b959-a1f012e83068.JPG)



When we click on the Money Transfer button;
we can transfer Money, after the required fields are entered.
![NonCustomerTransferMoney](https://user-images.githubusercontent.com/128610192/231908834-8f71f16e-d790-4c41-9213-29d6379ed914.JPG)






