using LinkedListProblem;

var ll = new LinkedList();
ll.InsertTail("www.google.com"); 
ll.InsertHead("https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8");
ll.InsertHead("https://en.wikipedia.org/wiki/Capital_of_Georgia");
ll.InsertHead("https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8");
ll.InsertHead("https://www.exploregeorgia.org/blog/georgias-state-capitals-1868-present");
ll.InsertHead("https://www.google.com/search?rlz=1C1VDKB_enUS1044US1044&sxsrf=AJOqlzVe5_KG6a8_qOhWcDdl9kdyiaGCEw:1677489409575&si=AEcPFx6l3RvH8SFlhHZyn7jIc6m2bU9vmoFvFAMQv2WWSYjXN5xOJC6Pl1o9HQBiiNghWdZeIpgMTFMqdw8b-ijMdF_zQMZqQtFvrgDTnktac5EXwwuclE8-RBrHTccRHeoXg0f4Xs9mZySPcUYZ-B_oWMTzAwsAast9IFXYjZxD-mgqNf7ooRWZoB4UvxdKdyL4PkU6wlUqknf6G8XDzU-6jvs3_QbYFA%3D%3D&q=Kermit+the+Frog&sa=X&ved=2ahUKEwjs7vyCr7X9AhU0iO4BHdlPAR4Qs9oBKAB6BAgzEAI&biw=1536&bih=714&dpr=1.25");
Console.WriteLine("\n================== Test 1 ==================\n");
ll.PrintList();
//<LinkedList>{
// https://www.google.com/search?rlz=1C1VDKB_enUS1044US1044&sxsrf=AJOqlzVe5_KG6a8_qOhWcDdl9kdyiaGCEw:1677489409575&si=AEcPFx6l3RvH8SFlhHZyn7jIc6m2bU9vmoFvFAMQv2WWSYjXN5xOJC6Pl1o9HQBiiNghWdZeIpgMTFMqdw8b-ijMdF_zQMZqQtFvrgDTnktac5EXwwuclE8-RBrHTccRHeoXg0f4Xs9mZySPcUYZ-B_oWMTzAwsAast9IFXYjZxD-mgqNf7ooRWZoB4UvxdKdyL4PkU6wlUqknf6G8XDzU-6jvs3_QbYFA%3D%3D&q=Kermit+the+Frog&sa=X&ved=2ahUKEwjs7vyCr7X9AhU0iO4BHdlPAR4Qs9oBKAB6BAgzEAI&biw=1536&bih=714&dpr=1.25
// https://www.exploregeorgia.org/blog/georgias-state-capitals-1868-present
// https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8
// https://en.wikipedia.org/wiki/Capital_of_Georgia
// https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8
// www.google.com
        
Console.WriteLine("\n================== Test 2 ==================\n");
ll.InsertTail("https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx5y3cpWB8t3QIlw940Bbgd-HLN-aNYSTraERzz0WyAsdADXfMstqEu5EC0uHSt_qFhk3GSBvUikP08byIDG3DRPA-I0qfNlvzHRpAvN4KcdhXLlzSZuFli1Iwb11WErqv5kCA-z9RTymnOiIq5vtmK-24gxzavlb-mNkP3JVU7iOozQe8qHxwU4glnfO6nRrsKOIQ3sq5tKJD-uoUoovPoJjNLUmbvrIDH-Sbx9eKxP6nA74ROo1GW1-SWNARJCFIogPCrC&q=Pep%C3%A9+Le+Pew&lei=BnX8Y9inA4D8kPIPj9aO-AU");
ll.InsertTail("https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx5y3cpWB8t3QIlw940Bbgd-HLN-aNYSTraERzz0WyAsdHpAI8JPE3KhqRczz6bF5j5vA4S_pip8GB74XviMYjMdpRet57Dc2XyaJhqc3nL-ISbabyUXmy_lSAhUo0NddTVUqH431Qx0D9gicWDPdPxDVVYOLQKFUZ5IuFoicnbSISQu23SOu6FT5ZSMc_7IvXbPZipTmK6kkPwdnEAVTuInxIBsq6wc7t4hgD3ykoK44HWzZDKycVFnDY0qw1TylUgvQrED&q=Mr.+Krabs&lei=9HX8Y6iPItDakPIPk5mn-Ac");
ll.PrintList();
//<LinkedList>{
//https://www.google.com/search?rlz=1C1VDKB_enUS1044US1044&sxsrf=AJOqlzVe5_KG6a8_qOhWcDdl9kdyiaGCEw:1677489409575&si=AEcPFx6l3RvH8SFlhHZyn7jIc6m2bU9vmoFvFAMQv2WWSYjXN5xOJC6Pl1o9HQBiiNghWdZeIpgMTFMqdw8b-ijMdF_zQMZqQtFvrgDTnktac5EXwwuclE8-RBrHTccRHeoXg0f4Xs9mZySPcUYZ-B_oWMTzAwsAast9IFXYjZxD-mgqNf7ooRWZoB4UvxdKdyL4PkU6wlUqknf6G8XDzU-6jvs3_QbYFA%3D%3D&q=Kermit+the+Frog&sa=X&ved=2ahUKEwjs7vyCr7X9AhU0iO4BHdlPAR4Qs9oBKAB6BAgzEAI&biw=1536&bih=714&dpr=1.25,
//https://www.exploregeorgia.org/blog/georgias-state-capitals-1868-present,
//https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8,
//https://en.wikipedia.org/wiki/Capital_of_Georgia,
//https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8,
//www.google.com,
//https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx5y3cpWB8t3QIlw940Bbgd-HLN-aNYSTraERzz0WyAsdADXfMstqEu5EC0uHSt_qFhk3GSBvUikP08byIDG3DRPA-I0qfNlvzHRpAvN4KcdhXLlzSZuFli1Iwb11WErqv5kCA-z9RTymnOiIq5vtmK-24gxzavlb-mNkP3JVU7iOozQe8qHxwU4glnfO6nRrsKOIQ3sq5tKJD-uoUoovPoJjNLUmbvrIDH-Sbx9eKxP6nA74ROo1GW1-SWNARJCFIogPCrC&q=Pep%C3%A9+Le+Pew&lei=BnX8Y9inA4D8kPIPj9aO-AU,
//https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx5y3cpWB8t3QIlw940Bbgd-HLN-aNYSTraERzz0WyAsdHpAI8JPE3KhqRczz6bF5j5vA4S_pip8GB74XviMYjMdpRet57Dc2XyaJhqc3nL-ISbabyUXmy_lSAhUo0NddTVUqH431Qx0D9gicWDPdPxDVVYOLQKFUZ5IuFoicnbSISQu23SOu6FT5ZSMc_7IvXbPZipTmK6kkPwdnEAVTuInxIBsq6wc7t4hgD3ykoK44HWzZDKycVFnDY0qw1TylUgvQrED&q=Mr.+Krabs&lei=9HX8Y6iPItDakPIPk5mn-Ac}

Console.WriteLine("\n================== Test 3 ==================\n");
ll.InsertAfter("www.google.com", "https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx7HnMxbNS2egwqbd2fGseeWkZi3ZCVlQ3vY-NLoLE7SWcJvPppDLqhCuGj8IKaAnsYDVkFeKhSIBsCQjKyvZmULAeB-b07SNG7bPagB0ipoMG13mmfAmOJYjQ75xVnkojM_jG38jRnXIW_YsNJn6poRZE14RgUSwcUGVxXsRVxkIbqlqS1uVwVZhCljaik8ymsYfVcAocVh6EIITyuPwMEI3PYuf0gyrHraNOv_OKLDig7cGQHo7WcRMUUoN1NFmLX5tCZU&q=Robbie+Rotten&lei=Bnb8Y6zyBK2lkPIPio-OyAo");
ll.PrintList();
//<LinkedList>{
// https://www.google.com/search?rlz=1C1VDKB_enUS1044US1044&sxsrf=AJOqlzVe5_KG6a8_qOhWcDdl9kdyiaGCEw:1677489409575&si=AEcPFx6l3RvH8SFlhHZyn7jIc6m2bU9vmoFvFAMQv2WWSYjXN5xOJC6Pl1o9HQBiiNghWdZeIpgMTFMqdw8b-ijMdF_zQMZqQtFvrgDTnktac5EXwwuclE8-RBrHTccRHeoXg0f4Xs9mZySPcUYZ-B_oWMTzAwsAast9IFXYjZxD-mgqNf7ooRWZoB4UvxdKdyL4PkU6wlUqknf6G8XDzU-6jvs3_QbYFA%3D%3D&q=Kermit+the+Frog&sa=X&ved=2ahUKEwjs7vyCr7X9AhU0iO4BHdlPAR4Qs9oBKAB6BAgzEAI&biw=1536&bih=714&dpr=1.25
// https://www.exploregeorgia.org/blog/georgias-state-capitals-1868-present
// https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8
// https://en.wikipedia.org/wiki/Capital_of_Georgia
// https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8
// www.google.com
// https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx7HnMxbNS2egwqbd2fGseeWkZi3ZCVlQ3vY-NLoLE7SWcJvPppDLqhCuGj8IKaAnsYDVkFeKhSIBsCQjKyvZmULAeB-b07SNG7bPagB0ipoMG13mmfAmOJYjQ75xVnkojM_jG38jRnXIW_YsNJn6poRZE14RgUSwcUGVxXsRVxkIbqlqS1uVwVZhCljaik8ymsYfVcAocVh6EIITyuPwMEI3PYuf0gyrHraNOv_OKLDig7cGQHo7WcRMUUoN1NFmLX5tCZU&q=Robbie+Rotten&lei=Bnb8Y6zyBK2lkPIPio-OyAo
// https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx5y3cpWB8t3QIlw940Bbgd-HLN-aNYSTraERzz0WyAsdADXfMstqEu5EC0uHSt_qFhk3GSBvUikP08byIDG3DRPA-I0qfNlvzHRpAvN4KcdhXLlzSZuFli1Iwb11WErqv5kCA-z9RTymnOiIq5vtmK-24gxzavlb-mNkP3JVU7iOozQe8qHxwU4glnfO6nRrsKOIQ3sq5tKJD-uoUoovPoJjNLUmbvrIDH-Sbx9eKxP6nA74ROo1GW1-SWNARJCFIogPCrC&q=Pep%C3%A9+Le+Pew&lei=BnX8Y9inA4D8kPIPj9aO-AU
// https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx5y3cpWB8t3QIlw940Bbgd-HLN-aNYSTraERzz0WyAsdHpAI8JPE3KhqRczz6bF5j5vA4S_pip8GB74XviMYjMdpRet57Dc2XyaJhqc3nL-ISbabyUXmy_lSAhUo0NddTVUqH431Qx0D9gicWDPdPxDVVYOLQKFUZ5IuFoicnbSISQu23SOu6FT5ZSMc_7IvXbPZipTmK6kkPwdnEAVTuInxIBsq6wc7t4hgD3ykoK44HWzZDKycVFnDY0qw1TylUgvQrED&q=Mr.+Krabs&lei=9HX8Y6iPItDakPIPk5mn-Ac

Console.WriteLine("\n================== Test 4 ==================\n");
ll.Remove("www.google.com");
ll.PrintList(); 
//<LinkedList>{
// https://www.google.com/search?rlz=1C1VDKB_enUS1044US1044&sxsrf=AJOqlzVe5_KG6a8_qOhWcDdl9kdyiaGCEw:1677489409575&si=AEcPFx6l3RvH8SFlhHZyn7jIc6m2bU9vmoFvFAMQv2WWSYjXN5xOJC6Pl1o9HQBiiNghWdZeIpgMTFMqdw8b-ijMdF_zQMZqQtFvrgDTnktac5EXwwuclE8-RBrHTccRHeoXg0f4Xs9mZySPcUYZ-B_oWMTzAwsAast9IFXYjZxD-mgqNf7ooRWZoB4UvxdKdyL4PkU6wlUqknf6G8XDzU-6jvs3_QbYFA%3D%3D&q=Kermit+the+Frog&sa=X&ved=2ahUKEwjs7vyCr7X9AhU0iO4BHdlPAR4Qs9oBKAB6BAgzEAI&biw=1536&bih=714&dpr=1.25
// https://www.exploregeorgia.org/blog/georgias-state-capitals-1868-present
// https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8
// https://en.wikipedia.org/wiki/Capital_of_Georgia
// https://www.google.com/search?q=capital+of+georgia&rlz=1C1VDKB_enUS1044US1044&oq=capital+of+geor&aqs=chrome.0.0i433i512j69i57j0i512l4j46i175i199i512j0i512l3.4734j0j9&sourceid=chrome&ie=UTF-8
// https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx7HnMxbNS2egwqbd2fGseeWkZi3ZCVlQ3vY-NLoLE7SWcJvPppDLqhCuGj8IKaAnsYDVkFeKhSIBsCQjKyvZmULAeB-b07SNG7bPagB0ipoMG13mmfAmOJYjQ75xVnkojM_jG38jRnXIW_YsNJn6poRZE14RgUSwcUGVxXsRVxkIbqlqS1uVwVZhCljaik8ymsYfVcAocVh6EIITyuPwMEI3PYuf0gyrHraNOv_OKLDig7cGQHo7WcRMUUoN1NFmLX5tCZU&q=Robbie+Rotten&lei=Bnb8Y6zyBK2lkPIPio-OyAo
// https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx5y3cpWB8t3QIlw940Bbgd-HLN-aNYSTraERzz0WyAsdADXfMstqEu5EC0uHSt_qFhk3GSBvUikP08byIDG3DRPA-I0qfNlvzHRpAvN4KcdhXLlzSZuFli1Iwb11WErqv5kCA-z9RTymnOiIq5vtmK-24gxzavlb-mNkP3JVU7iOozQe8qHxwU4glnfO6nRrsKOIQ3sq5tKJD-uoUoovPoJjNLUmbvrIDH-Sbx9eKxP6nA74ROo1GW1-SWNARJCFIogPCrC&q=Pep%C3%A9+Le+Pew&lei=BnX8Y9inA4D8kPIPj9aO-AU
// https://www.google.com/search?sa=X&rlz=1C1VDKB_enUS1044US1044&biw=1536&bih=714&sxsrf=AJOqlzWQIMx1Fx7Eedk3aSrvzpp3DmbGug:1677489414060&si=AEcPFx5y3cpWB8t3QIlw940Bbgd-HLN-aNYSTraERzz0WyAsdHpAI8JPE3KhqRczz6bF5j5vA4S_pip8GB74XviMYjMdpRet57Dc2XyaJhqc3nL-ISbabyUXmy_lSAhUo0NddTVUqH431Qx0D9gicWDPdPxDVVYOLQKFUZ5IuFoicnbSISQu23SOu6FT5ZSMc_7IvXbPZipTmK6kkPwdnEAVTuInxIBsq6wc7t4hgD3ykoK44HWzZDKycVFnDY0qw1TylUgvQrED&q=Mr.+Krabs&lei=9HX8Y6iPItDakPIPk5mn-Ac

Console.WriteLine("\n================== Test 5 ==================\n");
ll.ClearList();
ll.PrintList(); 