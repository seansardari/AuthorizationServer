﻿using Owin;
using System.IdentityModel.Tokens;
using Thinktecture.IdentityModel.Owin;
using Thinktecture.IdentityModel.Tokens;

namespace Thinktecture.Samples
{
    public static class AuthConfig
    {
        public static void Configure(IAppBuilder app)
        {
            // no mapping of incoming claims to Microsoft types
            JwtSecurityTokenHandler.InboundClaimTypeMap = ClaimMappings.None;

            // validate JWT tokens from AuthorizationServer
            app.UseJwtBearerToken(
                issuer:     Constants.AS.IssuerName,
                audience:   Constants.Audience,
                signingKey: Constants.AS.SigningKey);

            // claims transformation
            app.UseClaimsTransformation(new ClaimsTransformationOptions
                {
                    ClaimsAuthenticationManager = new ClaimsTransformer()
                });
        }
    }
}