# swiyu Duende IDP MFA Aspire ASP.NET Core

[![.NET](https://github.com/swiss-ssi-group/swiyu-idp-mfa-aspire-aspnetcore/actions/workflows/dotnet.yml/badge.svg)](https://github.com/swiss-ssi-group/swiyu-idp-mfa-aspire-aspnetcore/actions/workflows/dotnet.yml)

## Getting started:

- [swiyu](https://swiyu-admin-ch.github.io/cookbooks/onboarding-base-and-trust-registry/)
- [Dev docs](DEV.md)
- [Changelog](CHANGELOG.md)

## Blogs

- [Issue and verify credentials using the Swiss Digital identity public beta, ASP.NET Core and .NET Aspire](https://damienbod.com/2025/08/04/issuer-and-verify-credentials-using-the-swiss-digital-identity-public-beta-asp-net-core-and-net-aspire/)
- [Use swiyu, the Swiss E-ID to authenticate users with Duende and .NET Aspire](https://damienbod.com/2025/10/27/use-swiyu-the-swiss-e-id-to-authenticate-users-with-duende-and-net-aspire/)
- [Implement MFA using swiyu, the Swiss E-ID with Duende IdentityServer, ASP.NET Core Identity and .NET Aspire](https://damienbod.com/2025/11/10/implement-mfa-using-swiyu-the-swiss-e-id-with-duende-identityserver-asp-net-core-identity-and-net-aspire/)

## Overview 
A Duende identity server is used as an OpenID Connect server for web applications. When the user authenticates, the Swiss E-ID can be used as a second factor to authenticate.
The applications are implemented using Aspire, ASP.NET Core and the Swiss public beta generic containers. The containers implement the OpenID verifiable credential standards and provide a simple API to integrate applications. Using swiyu is simple, but not a good way of doing authentication as it is not phishing resistant.

![Architecture](https://github.com/swiss-ssi-group/swiyu-idp-mfa-aspire-aspnetcore/blob/main/images/overview.drawio.png)

## Used OSS packages, containers, repositories 

- ImageMagick: https://github.com/manuelbl/QrCodeGenerator/tree/master/Demo-ImageMagick
- Microsoft Aspire: https://learn.microsoft.com/en-us/dotnet/aspire/get-started/aspire-overview
- Net.Codecrete.QrCodeGenerator: https://github.com/manuelbl/QrCodeGenerator/
- swiyu
  - https://github.com/swiyu-admin-ch/swiyu-verifier

## Register Flow (Authentication Flow using password and MFA (swiyu direct))

Used data:  given_name, family_name, birth_date and birth_place.

1. User has already an account and would like to attach an E-ID for authentication
2. User registers MFA swiyu
3. User validates authentication using E-ID
4. User authenticates using password and swiyu

> Note: authentication uses E-ID is NOT phishing resistant. Passkeys would be better.

## Login Flow

1. User enters username (email)
2. User enters email
3. User verifies using swiyu, validates against DB
4. Sign-in and create cookie

## Authentication Flow (swiyu direct)

> Note: authentication uses E-ID is NOT phishing resistant. Passkeys would be better.

## Recovery flow (name change)

## 2FA flow

## Password reset flow

## Links

https://swiyu-admin-ch.github.io/cookbooks/how-to-use-beta-id/

https://swiyu-admin-ch.github.io/cookbooks/onboarding-generic-verifier/

https://damienbod.com/2022/10/17/is-scanning-qr-codes-for-authentication-safe/

https://damienbod.com/2022/02/14/problems-with-online-user-authentication-when-using-self-sovereign-identity/