package com.codewithmosh.adapter;

public class Demo {
  public static void show() {
    var client = new EmailClient();
    client.addProvider(new GmailAdapter());
    client.downloadEmails();
  }
}
